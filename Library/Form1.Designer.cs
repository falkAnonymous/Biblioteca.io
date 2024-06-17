namespace Library
{
    partial class FormMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.dCardBook1 = new Library.Views.View_ControllerUser.DCardBook();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // dCardBook1
            // 
            this.dCardBook1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.dCardBook1.Description = "Descrição";
            this.dCardBook1.Images = ((System.Drawing.Image)(resources.GetObject("dCardBook1.Images")));
            this.dCardBook1.Location = new System.Drawing.Point(267, 22);
            this.dCardBook1.MaximumSize = new System.Drawing.Size(281, 403);
            this.dCardBook1.MinimumSize = new System.Drawing.Size(281, 403);
            this.dCardBook1.Name = "dCardBook1";
            this.dCardBook1.Size = new System.Drawing.Size(281, 403);
            this.dCardBook1.TabIndex = 0;
            this.dCardBook1.Title = "Titulo";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dCardBook1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Views.View_ControllerUser.DCardBook dCardBook1;
    }
}

