using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoExamen
{
    public partial class Form1 : Form
    {
        chat ch2 = new chat();
        ConectarBD cnx = new ConectarBD();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            chat ch3 = new chat();
            ch3 = cnx.retornarObjeto();
            if (ch3.Nmensaje > ch2.Nmensaje) {
                String mensaje;
                mensaje = cnx.mostrarMensaje();
                Label lbl_mensaje = new Label();
                lbl_mensaje.Text = mensaje;
                lbl_mensaje.BackColor = Color.AliceBlue;
                ch2 = ch3;
                lbl_mensaje.AutoSize = true;
                flowLayoutPanel1.Controls.Add(lbl_mensaje);
            }
            else
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ch2 = cnx.retornarObjeto();
            timer1.Enabled = true;
        }

        private void btn_enviar_Click_1(object sender, EventArgs e)
        {
            cnx.insertarMensaje(textBox1.Text);
            Label lbl_menviar = new Label();
            lbl_menviar.Text = textBox1.Text;
            lbl_menviar.BackColor = Color.Beige;
            lbl_menviar.AutoSize = true;
            flowLayoutPanel1.Controls.Add(lbl_menviar);
            textBox1.Clear();
        }
    }
}
