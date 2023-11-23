using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Mail;
using System.IO;
using Microsoft.VisualBasic;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Diagnostics;

namespace TPV
{
    public partial class TPV : Form
    {
        claseAccesoBD conexion = new claseAccesoBD();
        List<claseFruta> listaFrutas = new List<claseFruta>();
        List<claseCesta> listaCesta = new List<claseCesta>();
        List<String> ProductosBajoMinimo = new List<String>();
        List<claseFruta> frutaEncontrada = new List<claseFruta>();

        int contadorProductos = 0;
        double total = 0;

        public TPV()
        {
            InitializeComponent();
        }

        private void TPV_Load(object sender, EventArgs e)
        {
            gbInfo.Visible = false;
            listaFrutas = conexion.listarFrutas();
            foreach (claseFruta cf in listaFrutas)
            {
                Button btn = new Button();
                btn.Name = cf.Nombre;

                btn.Width = 120;
                btn.Height = 120;

                MemoryStream ms = new System.IO.MemoryStream(cf.Imagen);
                System.Drawing.Image imagen = System.Drawing.Image.FromStream(ms);
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.BackgroundImage = imagen;

                btn.Click += Btn_Click;
                btn.MouseHover += Btn_MouseHover;

                flpFrutas.Controls.Add(btn);

            }

        }

        private void Btn_MouseHover(object sender, EventArgs e)
        {
            Button btnX = (Button)sender;
            gbInfo.Visible = true;
            for (int i = 0; i < listaFrutas.Count; i ++) {
                if (btnX.Name == listaFrutas[i].Nombre) {
                    lbl_nombre.Text = listaFrutas[i].Nombre;
                    lblPrecio.Text = Convert.ToString(listaFrutas[i].Precio);
                    lblExistencias.Text = Convert.ToString(listaFrutas[i].Stock);
                    MemoryStream ms = new MemoryStream(listaFrutas[i].Imagen);
                    pcb_Info.Image = System.Drawing.Image.FromStream(ms);

                }
            }
        }

        private void Btn_Click(object sender, EventArgs e) // Botones de frutas
        {
            Button btnx = (Button)sender;

            foreach (claseFruta cf in listaFrutas)
            {
                if (cf.Nombre == btnx.Name)
                {
                    if (cf.Stock <= 0)
                    {
                        MessageBox.Show("No hay existencias de este producto.");
                    }
                    else
                    {

                        MessageBox.Show("Has seleccionado " + cf.Nombre + ". Existencias: " + cf.Stock, "TPV Frutería Vero");
                        String peso = Interaction.InputBox("Introduce peso en kgs", "TPV Frutería Vero");

                        if (peso == "" || Convert.ToDouble(peso) <= 0)
                        {
                            MessageBox.Show("Cantidad errónea.");
                        }
                        else
                        {
                            contadorProductos++;
                            claseCesta producto = new claseCesta();
                            producto.Articulo = contadorProductos;
                            producto.Nombre = cf.Nombre;
                            producto.Peso = Convert.ToDouble(peso);
                            producto.PrecioUnitario = Math.Round(Convert.ToDouble(cf.Precio), 2);
                            producto.PrecioParcial = Math.Round(producto.Peso * producto.PrecioUnitario, 2);

                            total += producto.PrecioParcial;

                            lblTotal.Text = Convert.ToString(total);

                            listaCesta.Add(producto);
                            cf.Stock -= Convert.ToInt32(peso);

                            dgv1.DataSource = null;
                            dgv1.DataSource = listaCesta;
                        }
                    }
                }
            }
            gbInfo.Visible = false;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            mandarMail(imprimirTicket(), txtMail.Text);
            dgv1.DataSource = null;
            conexion.modificarStock(listaCesta, listaFrutas);
            listaCesta.Clear();
            listaFrutas = conexion.listarFrutas();
            lblTotal.Text = "";
        }

        private String imprimirTicket()
        {
            //crear objeto pdfTAble a partir del datagrid
            PdfPTable pdfTable = new PdfPTable(dgv1.ColumnCount);
            //separación texto de las celdas del contenido
            pdfTable.DefaultCell.Padding = 3;
            //ancho de la tabla
            pdfTable.WidthPercentage = 80;
            //alineación del texto dentro de las celdas
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            //ancho del borde
            pdfTable.DefaultCell.BorderWidth = 1;
            //encabezamiento de las columnas
            foreach (DataGridViewColumn column in dgv1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }
            //contenidos de las filas
            foreach (DataGridViewRow row in dgv1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    try { pdfTable.AddCell(cell.Value.ToString()); }
                    catch { }
                }
            }
            //etiqueta con el total a pagar
            PdfPCell cellTotal = new PdfPCell(new Phrase(lblTotal.Text));
            PdfPCell celdaVacia = new PdfPCell(new Phrase(""));
            pdfTable.AddCell(celdaVacia);
            pdfTable.AddCell(celdaVacia);
            pdfTable.AddCell(celdaVacia);
            pdfTable.AddCell("Total:");
            pdfTable.AddCell(cellTotal);
            string folderPath = "C:\\ticket\\";
            //si no existe el directorio ticket se genera
            if (!Directory.Exists(folderPath)) { Directory.CreateDirectory(folderPath); }
            //para colocar la fecha actual de impresión
            DateTime dt = DateTime.Now;
            string s = dt.ToString("yyyyMMddHHmmss");
            string cadenaFinal = folderPath + "ticket" + s + ".pdf";
            //crear el documento o fichero físico
            using (FileStream stream = new FileStream(folderPath + "ticket" + s + ".pdf", FileMode.Create))
            {
                //dimensiones del documento
                Document pdfDoc = new Document(PageSize.A4, 20f, 20f, 20f, 20f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                //incluir una imagen, indicar la ruta
                string patimagen = Path.Combine(Application.StartupPath, "logo.png");
                //integrar la imagen con dimensiones en el pdfdoc
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(patimagen);
                img.ScaleAbsolute(210, 70);
                img.ScalePercent(50);
                pdfDoc.Add(img);
                //texto informativo
                pdfDoc.Add(new Paragraph("Frutería Vero"));
                pdfDoc.Add(new Paragraph("CIF: A1234567B"));
                pdfDoc.Add(new Paragraph("c/ Joaquín Alcalde s/n"));
                pdfDoc.Add(new Paragraph("10300 Navalmoral de la Mata"));
                pdfDoc.Add(new Paragraph("Cáceres."));
                pdfDoc.Add(new Paragraph("\n\n"));
                //integrar la tabla creada en la parte superior
                pdfDoc.Add(pdfTable);
                pdfDoc.Add(new Paragraph("\n\n"));
                //más información
                pdfDoc.Add(new Paragraph("Fecha/Hora Compra: " + DateTime.Now.ToString("dd-MM-yy, HH:mm:ss")));
                pdfDoc.Add(new Paragraph("Le atendió: Faissal"));
                pdfDoc.Close();
            }
            //proceso de windows para levantar en pantalla el pdf
            Process pc = new Process();
            pc.StartInfo.FileName = cadenaFinal;
            pc.Start();
            return cadenaFinal;

        }

        private void mandarMail(String archivo, String mail)
        {
            try
            {
                //correo saliente y pwd
                string email = "ffatmi02@educarex.es";
                string password = "dxycbvaqwadxfdnc";
                //activar las credenciales
                var loginInfo = new NetworkCredential(email, password);
                //construir el mensaje
                var msg = new MailMessage();
                //protocolo smtp
                var smtpClient = new SmtpClient("smtp.gmail.com", 25);
                //correo saliente
                msg.From = new MailAddress("ffatmi02@educarex.es");
                //correo destinatario
                msg.To.Add(new MailAddress(mail));
                //asunto
                msg.Subject = "Compra en Frutería Vero";
                //cuerpo del mensaje
                msg.Body = "Gracias por su compra.";
                //adjuntar fichero
                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(archivo);
                msg.Attachments.Add(attachment);
                msg.IsBodyHtml = true;
                //activar protocolos de segunridad
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = loginInfo;
                //enviar el mensaje
                smtpClient.Send(msg);
                //limpiar el canal de salida
                smtpClient.Dispose();
                MessageBox.Show("Mensaje enviado");
            }
            catch (Exception) { MessageBox.Show("mensaje no enviado"); }

        }
        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            btnEmpezar.Visible = false;
            flpFrutas.Visible = true;
            btnPagar.Visible = true;
            lblTotal.Visible = true;
            dgv1.Visible = true;
            label1.Visible = true;
            txtMail.Visible = true;
            btnAdministrar.Visible = true;
            labelEuro.Visible = true;
            labelTotal.Visible = true;
            lblBusca.Visible = true;
            txtBuscar.Visible = true;
            gbInfo.Visible = false;
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            Inicio ini = new Inicio();
            ini.ShowDialog();
            this.Hide();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            flpFrutas.Controls.Clear();
            for (int i = 0; i < listaFrutas.Count; i ++)
            {
                if (listaFrutas[i].Nombre.StartsWith(txtBuscar.Text))
                {
                    Button btnX = new Button();
                    MemoryStream ms = new MemoryStream(listaFrutas[i].Imagen);
                    btnX.Width = 120;
                    btnX.Height = 120;
                    btnX.BackgroundImageLayout = ImageLayout.Stretch;
                    btnX.BackgroundImage = System.Drawing.Image.FromStream(ms);
                    btnX.Name = listaFrutas[i].Nombre;
                    btnX.Click += Btn_Click;
                    btnX.MouseHover += Btn_MouseHover;
                    flpFrutas.Controls.Add(btnX);
                }
            }
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gbInfo.Visible = false;
            DialogResult confirmarEliminar = MessageBox.Show("¿Estás seguro de eliminar este producto?", "Frutería Vero", MessageBoxButtons.YesNo);
            if (confirmarEliminar == DialogResult.Yes)
            {
                int filaSeleccionada = dgv1.CurrentCell.RowIndex;
                double precioRestar = listaCesta.ElementAt(filaSeleccionada).PrecioParcial;

                listaCesta.RemoveAt(filaSeleccionada);

                dgv1.DataSource = null;
                dgv1.DataSource = listaCesta;
                total -= precioRestar;
                lblTotal.Text = Convert.ToString(total);
            }
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void dgv1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}

