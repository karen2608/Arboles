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
    public partial class ARBOL : Form
    {
        public ARBOL()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ESCENARIO_1 ven = new ESCENARIO_1();
            ven.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ESCENRARIO_2 ven = new ESCENRARIO_2();
            ven.Show();
            this.Hide();
        }
    }
}
