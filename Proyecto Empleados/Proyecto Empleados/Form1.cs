using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Empleados
{
    public partial class Form1 : Form
    {
        List<Empleados> listaEm2 = new List<Empleados>();
        ConectarBD cnx = new ConectarBD();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnx.InsertarEmpleado(Convert.ToString(textBox1.Text), Convert.ToString(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToString(textBox4.Text));
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            MessageBox.Show("El empleado se ha insertado correctamente", "Info", MessageBoxButtons.OK);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaEm2 = cnx.ListarEmpleados();
            dataGridView1.DataSource = listaEm2;
        }
    }
}
