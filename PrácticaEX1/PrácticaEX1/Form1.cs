using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrácticaEX1
{
    public partial class Form1 : Form
    {
        Random r1 = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            int cont1 = 0;
            int cont2 = 0;
            int cont3 = 0;
            int cont4 = 0;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel3.Controls.Clear();
            flowLayoutPanel4.Controls.Clear();
            if (int.Parse(textBox1.Text) > 0 && int.Parse(textBox1.Text) < 101) {

                for (int i = 0; i < int.Parse(textBox1.Text); i++)
                {
                    int num_random = r1.Next(1, 100);
                    if (num_random > 0 && num_random < 26)
                    {
                        cont1++;
                        Label lbl1 = new Label();
                        lbl1.Text = Convert.ToString(num_random);
                        lbl1.ForeColor = Color.Blue;
                        flowLayoutPanel1.Controls.Add(lbl1);

                    } else if (num_random > 25 && num_random < 51)
                    {
                        cont2++;
                        Label lbl2 = new Label();
                        lbl2.Text = Convert.ToString(num_random);
                        lbl2.ForeColor = Color.Green;
                        flowLayoutPanel2.Controls.Add(lbl2);
                    } else if (num_random > 50 && num_random < 76)
                    {
                        cont3++;
                        Label lbl3 = new Label();
                        lbl3.Text = Convert.ToString(num_random);
                        lbl3.ForeColor = Color.Orange;
                        flowLayoutPanel3.Controls.Add(lbl3);
                    }
                    else if (num_random > 75 && num_random < 101)
                    {
                        cont4++;
                        Label lbl4 = new Label();
                        lbl4.Text = Convert.ToString(num_random);
                        lbl4.ForeColor = Color.Red;
                        flowLayoutPanel4.Controls.Add(lbl4);
                    }
                }
            }
            else
            {
                MessageBox.Show("Error, debe colocar un número entre 0 y 100", "Info", MessageBoxButtons.OK);
            }
            lbl_cantidad1.Text = Convert.ToString(cont1);
            lbl_cantidad2.Text = Convert.ToString(cont2);
            lbl_cantidad3.Text = Convert.ToString(cont3);
            lbl_cantidad4.Text = Convert.ToString(cont4);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult resultado = MessageBox.Show("Seguro que quieres salir del programa?", "Info", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    this.Close();
                }
                else
                {

                }
            }
        }
    }
}
