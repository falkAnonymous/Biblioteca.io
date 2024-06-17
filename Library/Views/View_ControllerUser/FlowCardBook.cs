using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Views.View_ControllerUser
{
    public partial class FlowCardBook : UserControl
    {
        static private string _Path = @"D:\Atalhos Area de trabalho\scripts\Csharp Linguagem\Framework\Windows Form\Book Management\Library\Images\LoginIcon.png";
        public Image _Picture { get; private set; } = Image.FromFile(_Path);
        public string _Title { get; private set; } = "Titulo";

        public FlowCardBook()
        {
            InitializeComponent();

            lblTitle.Text = _Title;
            pictureBookF.Image = _Picture;
        }
        [Category("Settings")]
        public Image PictureCardBook
        {
            get { return _Picture; }
            set
            {
                _Picture = value;
                try
                {
                    pictureBookF.Image = _Picture;
                    pictureBookF.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Encontramos um erro" + e.Message);
                }



            }
        }
        [Category("Settings")]
        public string Title
        {
            get { return _Title; }
            set
            {
                _Title = value;
                lblTitle.Text = _Title;

            }
        }

        private void FlowCardBook_Load(object sender, EventArgs e)
        {
            siticonePanel1.FillColor = Color.FromArgb(100, 48, 192, 205);
        }
    }
}