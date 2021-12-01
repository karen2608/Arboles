using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Arboles
{
    public partial class ESCENARIO_1 : Form
    {
        public ESCENARIO_1()
        {
            InitializeComponent();
        }
        
        private void gRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics nodo;
            nodo = CreateGraphics();
            nodo.FillEllipse(Brushes.White, 320, 30, 35, 35);
            nodo.DrawString("25", Font, Brushes.Black, 330, 40);
            Pen mynodor = new Pen(Color.White, 3);
            nodo.DrawEllipse(mynodor, 320, 30, 35, 35);

            nodo.FillEllipse(Brushes.White, 200, 80, 35, 35);
            nodo.DrawString("10", Font, Brushes.Black, 210, 90);
            Pen mynodo1 = new Pen(Color.White, 3);
            nodo.DrawEllipse(mynodo1, 200, 80, 35, 35);

            nodo.FillEllipse(Brushes.White, 140, 130, 35, 35);
            nodo.DrawString("7", Font, Brushes.Black, 150, 140);
            Pen mynodo2 = new Pen(Color.White, 3);
            nodo.DrawEllipse(mynodo2, 140, 130, 35, 35);

            nodo.FillEllipse(Brushes.White, 260, 130, 35, 35);
            nodo.DrawString("12", Font, Brushes.Black, 270, 140);
            Pen mynodo3 = new Pen(Color.White, 3);
            nodo.DrawEllipse(mynodo3, 260, 130, 35, 35);

            nodo.FillEllipse(Brushes.White, 440, 80, 35, 35);
            nodo.DrawString("35", Font, Brushes.Black, 450, 90);
            Pen mynodo4 = new Pen(Color.White, 3);
            nodo.DrawEllipse(mynodo4, 440, 80, 35, 35);

            nodo.FillEllipse(Brushes.White, 500, 130, 35, 35);
            nodo.DrawString("50", Font, Brushes.Black, 510, 140);
            Pen mynodo5 = new Pen(Color.White, 3);
            nodo.DrawEllipse(mynodo5, 500, 130, 35, 35);

            nodo.FillEllipse(Brushes.White, 380, 130, 35, 35);
            nodo.DrawString("28", Font, Brushes.Black, 390, 140);
            Pen mynodo6 = new Pen(Color.White, 3);
            nodo.DrawEllipse(mynodo6, 380, 130, 35, 35);

            Pen myline = new Pen(Color.White, 2);
            nodo.DrawLine(myline, 353, 50, 443, 84);

            Pen myline1 = new Pen(Color.White, 2);
            nodo.DrawLine(myline1, 474, 107, 504, 135);

            Pen myline3 = new Pen(Color.White, 2);
            nodo.DrawLine(myline3, 440, 106, 408, 134);

            Pen myline4 = new Pen(Color.White, 2);
            nodo.DrawLine(myline4, 319, 50, 232, 87);

            Pen myline5 = new Pen(Color.White, 2);
            nodo.DrawLine(myline5, 200, 101, 171, 136);

            Pen myline6 = new Pen(Color.White, 2);
            nodo.DrawLine(myline6, 236, 101, 265, 134);

        }

        private void rECORRIDOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rECORRIDOENPREORDENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics preorden;
            preorden = CreateGraphics();
            preorden.DrawString("PREORDEN: ", Font, Brushes.White, 30, 310);
            preorden.DrawString("25", Font, Brushes.White, 100, 310);
            preorden.DrawString("10", Font, Brushes.White, 140, 310);
            preorden.DrawString("7", Font, Brushes.White, 180, 310);
            preorden.DrawString("12", Font, Brushes.White, 220, 310);
            preorden.DrawString("35", Font, Brushes.White, 260, 310);
            preorden.DrawString("28", Font, Brushes.White, 300, 310);
            preorden.DrawString("50", Font, Brushes.White, 340, 310);

        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ESCENARIO_1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = e.X.ToString();
            textBox2.Text = e.Y.ToString();
        }

        private void rECORRIDOENINORDENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics preorden;
            preorden = CreateGraphics();
            preorden.DrawString("INORDEN: ", Font, Brushes.White, 30, 344);
            preorden.DrawString("7", Font, Brushes.White, 100, 344);
            preorden.DrawString("10", Font, Brushes.White, 140, 344);
            preorden.DrawString("12", Font, Brushes.White, 180, 344);
            preorden.DrawString("25", Font, Brushes.White, 220, 344);
            preorden.DrawString("28", Font, Brushes.White, 260, 344);
            preorden.DrawString("35", Font, Brushes.White, 300, 344);
            preorden.DrawString("50", Font, Brushes.White, 340, 344);
        }

        private void rECIRRIDOENPOSORDENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics preorden;
            preorden = CreateGraphics();
            preorden.DrawString("POSORDEN: ", Font, Brushes.White, 30, 378);
            preorden.DrawString("7", Font, Brushes.White, 100, 378);
            preorden.DrawString("12", Font, Brushes.White, 140, 378);
            preorden.DrawString("10", Font, Brushes.White, 180, 378);
            preorden.DrawString("28", Font, Brushes.White, 220, 378);
            preorden.DrawString("50", Font, Brushes.White, 260, 378);
            preorden.DrawString("35", Font, Brushes.White, 300, 378);
            preorden.DrawString("25", Font, Brushes.White, 340, 378);
        }
    }
}
