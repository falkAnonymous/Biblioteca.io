namespace Library.Views.View_ControllerUser
{
    partial class DCardBook
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBook = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDownloand = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBook)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBook);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(281, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 164);
            this.panel1.TabIndex = 0;
            // 
            // pictureBook
            // 
            this.pictureBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBook.Location = new System.Drawing.Point(63, 14);
            this.pictureBook.Name = "pictureBook";
            this.pictureBook.Size = new System.Drawing.Size(160, 133);
            this.pictureBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBook.TabIndex = 0;
            this.pictureBook.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDownloand);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblDescription);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 239);
            this.panel2.TabIndex = 1;
            // 
            // btnDownloand
            // 
            this.btnDownloand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownloand.AutoRoundedCorners = true;
            this.btnDownloand.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnDownloand.BorderRadius = 16;
            this.btnDownloand.BorderThickness = 1;
            this.btnDownloand.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDownloand.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDownloand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDownloand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDownloand.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDownloand.ForeColor = System.Drawing.Color.White;
            this.btnDownloand.Location = new System.Drawing.Point(41, 189);
            this.btnDownloand.Name = "btnDownloand";
            this.btnDownloand.Size = new System.Drawing.Size(192, 34);
            this.btnDownloand.TabIndex = 3;
            this.btnDownloand.Text = "Baixar";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.panel3.Location = new System.Drawing.Point(7, 8);
            this.panel3.MaximumSize = new System.Drawing.Size(10, 83);
            this.panel3.MinimumSize = new System.Drawing.Size(10, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 10);
            this.panel3.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Poppins Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDescription.Location = new System.Drawing.Point(3, 98);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(275, 76);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "label2";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Poppins Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(25, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(253, 95);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // DCardBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(281, 403);
            this.MinimumSize = new System.Drawing.Size(281, 403);
            this.Name = "DCardBook";
            this.Size = new System.Drawing.Size(281, 403);
            this.Load += new System.EventHandler(this.DCardBook_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBook)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBook;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnDownloand;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}
