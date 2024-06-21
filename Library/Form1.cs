using System;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class FormMain : Form
    {
        bool Ativador;
        int x, y;
        Point point;

        public FormMain()
        {
            InitializeComponent();
        }

        // Manipulador de evento quando o mouse é pressionado no painel
        private void bunifuPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            Ativador = true;
            x = e.X;
            y = e.Y;
        }

        // Manipulador de evento quando o mouse é movido sobre o painel
        private void bunifuPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Ativador)
            {
                int deltax = e.X - x;
                int deltay = e.Y - y;
                this.Location = point = new Point(this.Location.X + deltax, this.Location.Y + deltay);
            }
        }

        // Manipulador de evento quando o mouse é liberado após arrastar
        private void bunifuPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            Ativador = false;
        }
    }
}
