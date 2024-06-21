using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Views
{
    public partial class FormUser : Form
    {
        bool Ativador;
        int x, y;
        Point _point;

        public FormUser()
        {
            InitializeComponent();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Ativador = true;
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (Ativador)
            {
                int deltax = e.X - x;
                int deltay = e.Y - y;
                this.Location = _point = new Point(this.Location.X + deltax, this.Location.Y + deltay);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Ativador = false;
        }
    }
}
