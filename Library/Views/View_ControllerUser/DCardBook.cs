using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Library.Views.View_ControllerUser
{
    public partial class DCardBook : UserControl
    {
        public string _Title { get; private set; } = "Titulo";
        public string _Description { get; private set; } = "Descrição";
        static string path = @"D:\Atalhos Area de trabalho\scripts\Csharp Linguagem\Framework\Windows Form\Book Management\Library\Images\loginIcon.png";
        public Image _Image { get; private set; } = Image.FromFile(path);

        int contador1 = 0;
        int contador2 = 0;
        int contador3 = 1;


        public DCardBook()
        {
            InitializeComponent();
            this.lblDescription.Text = _Description;
            this.lblTitle.Text = _Title;
            this.pictureBook.Image = _Image;

            panel3.Height = 10;
            timer3.Start();
        }

        [Category("Settings")]
        public string Title
        {
            get { return _Title; }

            set
            {
                _Title = value;
                contador1 = 0;
                lblTitle.Text = _Title;
                lblTitle.Text = "";
                timer1.Start();
            }
        }
        [Category("Settings")]
        public string Description
        {
            get { return _Description; }
            set
            {
                _Description = value;
                contador2 = 0;
                lblDescription.Text = _Description;
                lblDescription.Text = "";
                timer2.Start();
            }
        }
        [Category("Settings")]
        public Image Images
        {
            get { return _Image; }
            set
            {
                _Image = value;
                    try
                    {                       
                        pictureBook.Image = _Image;
                        pictureBook.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch (Exception e)
                    {

                        MessageBox.Show("A conteceu um erro: " + e.Message);
                    }
                
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            if (contador1 < _Title.Length)
            {
                lblTitle.Text += _Title[contador1];
                contador1++;
            }
            else
            {
                ((Timer)sender).Stop();
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            if (contador2 < _Description.Length)
            {
                lblDescription.Text += _Description[contador2];
                contador2++;
            }
            else
            {
                ((Timer)sender).Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Interval = 10;
            panel3.Height += contador3;
            if (panel3.Height == panel3.MaximumSize.Height)
            {
                timer3.Stop();
            }
            
        }
        private void DCardBook_Load(object sender, EventArgs e)
        {
            

            if (pictureBook.Image == null)
            {
                pictureBook.Image = Images;
            }

            
        }
    }
}