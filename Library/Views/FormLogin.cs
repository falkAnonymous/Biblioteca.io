using System;
using System.Drawing;
using System.Windows.Forms;

namespace Library.Views
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            bunifuPanel1.BackgroundColor = Color.FromArgb(100, 33, 37, 41); // Background Painel Formulario
        }
        
    }
}
