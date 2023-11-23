using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Alturas
{
    public partial class Form1 : Form
    {
        ConectarBD cnx = new ConectarBD();
        List<Altura> listaA = new List<Altura>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaA = cnx.CargarAlturas();
            dataGridView1.DataSource = listaA;
        }
    }
}
