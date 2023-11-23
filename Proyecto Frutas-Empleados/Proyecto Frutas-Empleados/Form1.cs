using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Frutas_Empleados
{
    public partial class Form1 : Form
    {
        List<Empleados> listaEm = new List<Empleados>();
        List<Frutas> listaFr = new List<Frutas>();
        ConectarBD cnx = new ConectarBD();
        String nombreFichero;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaEm = cnx.listarEmpleados();
            listaFr = cnx.listarFrutas();

            dataGridView1.DataSource = listaEm;
            dataGridView2.DataSource = listaFr;
        }

        private void btn_examinar_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf1 = new OpenFileDialog();
            opf1.Filter = "imagenes|*.jpg*.png";
            if (opf1.ShowDialog() == DialogResult.OK)
            {
                nombreFichero = opf1.FileName;
                pictureBox1.Image = Image.FromFile(nombreFichero);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(listaEm[fila].Imagen);
            MemoryStream ms = new MemoryStream(bytes);
            System.Drawing.Image imagen = System.Drawing.Image.FromStream(ms);
            btn_.BackgroundImage = imagen;
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            byte[] bloque = listaFr[fila].Imagen;
            MemoryStream ms = new MemoryStream(bloque);
            btn_imgFrutas.BackgroundImage = Image.FromStream(ms);
        }

        private void btn_agregarFruta_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(nombreFichero, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] bloque = br.ReadBytes((int)fs.Length);
            cnx.InsertarFruta(textBox1.Text, Convert.ToDouble(textBox2.Text), bloque);
        }
    }
}
