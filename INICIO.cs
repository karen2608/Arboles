using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles
{
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cod= "1000897727";
            if (textBox2.Text==""|| textBox2.Text==cod)
            {
                ARBOL ven = new ARBOL();
                ven.Show();
                this.Hide();
            }
            else if(textBox2.Text!=cod)
            {
                MessageBox.Show("CÓDIGO INCORRECTO");
                textBox2.Clear();
                textBox2.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
