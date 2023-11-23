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
using Microsoft.VisualBasic;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Diagnostics;
using Image = System.Drawing.Image;

namespace TPV
{
    public partial class backEnd : Form
    {
        claseAccesoBD conexion = new claseAccesoBD();
        List<claseFruta> listaFrutas = new List<claseFruta>();
        List<String> productosBajoMinimo = new List<String>();
        String nombreImagen = "";
        public backEnd()
        {
            InitializeComponent();
            
        }
        private void backEnd_Load(object sender, EventArgs e)
        {
            listaFrutas = conexion.listaFrutas;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            TPV tpv = new TPV();
            tpv.ShowDialog();
            this.Hide();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            gbInsertar.Visible = false;
            flpFrutas.Visible = true;
            listaFrutas = conexion.listarFrutas();
            foreach (claseFruta cf in listaFrutas)
            {
                Button btn = new Button();
                btn.Text = cf.Nombre;
                btn.Tag = cf.Id;
                btn.Height = 40;
                btn.Width = 90;
                btn.Click += Btn_stock_click;
                flpFrutas.Controls.Add(btn);
            }

        }

        private void Btn_stock_click(object sender, EventArgs e)
        {
            Button btnX = (Button)sender;
            String peso = Interaction.InputBox("Introduce los kg a añadir", "TPV Frutería Vero");
            conexion.insertarStock(Convert.ToDouble(peso), Convert.ToInt32(btnX.Tag));
        }

        private void BotonS_Click(object sender, EventArgs e) // Para añadir stock
        {
            

        }

        private void btnInsertarFruta_Click(object sender, EventArgs e)
        {
            flpFrutas.Visible = false;
            gbInsertar.Visible = true;
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf1 = new OpenFileDialog();
            opf1.Filter = "imagenes|*.jpg;*.png";
            if (opf1.ShowDialog() == DialogResult.OK)
            {
                nombreImagen = opf1.FileName;
                FileStream fs = new FileStream(nombreImagen, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                MemoryStream ms = new MemoryStream(br.ReadBytes((int)fs.Length));
                pbImagenCargada.Image = Image.FromStream(ms);
            }
        }
        private void btnAniadir_Click(object sender, EventArgs e)
        {
            Button btnX = (Button)sender;
            FileStream fs = new FileStream(nombreImagen, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] imagen = br.ReadBytes((int)fs.Length);
            if (btnX.Text == "Insertar Fruta")
            {
                conexion.insertarFruta(obtenerUltimoId(), Convert.ToString(txtNombre.Text), Convert.ToDouble(txtPrecio.Text), imagen);
            }
            else
            {
                conexion.modificarFruta(txtNombre.Text, Convert.ToDouble(txtPrecio.Text), imagen, txtProcedencia.Text);
            }

        }

        private int obtenerUltimoId()
        {
            int ultimoId;
            int cont = 0;
            listaFrutas = conexion.listarFrutas();
            foreach (claseFruta cf in listaFrutas)
            {
                cont++;
            }
            ultimoId = listaFrutas[cont - 1].Id + 1;
            return ultimoId;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            flpFrutas.Visible = false;
            gbInsertar.Visible = true;
        }

        private void BotonM_Click(object sender, EventArgs e) // para modificar la fruta
        {
           

        }
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEliminarFruta_Click(object sender, EventArgs e)
        {
            gbInsertar.Visible = false;
            flpFrutas.Visible = true;
            listaFrutas = conexion.listarFrutas();
            foreach (claseFruta cf in listaFrutas)
            {
                Button btn = new Button();
                btn.Text = cf.Nombre;
                btn.Tag = cf.Id;
                btn.Height = 40;
                btn.Width = 90;
                btn.Click += Btn_eliminar_click;
                flpFrutas.Controls.Add(btn);
            }
        }

        private void Btn_eliminar_click(object sender, EventArgs e)
        {
            Button btnX = (Button)sender;
            conexion.eliminarFruta(Convert.ToInt32(btnX.Tag));
        }

        private void BotonE_Click(object sender, EventArgs e) // para eliminar frutas
        {
         
        }

        private void btnExclamacion_Click_1(object sender, EventArgs e)
        {
       
        }

        private String hacerPedido()
        {
            String pedido = "";

            return pedido;
        }

        private void mandarMailPedido(String archivo)
        {
         
        }
    }
}
