namespace Library.Views.View_ControllerUser
{
    partial class FlowCardBook
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
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnDetail = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBookF = new System.Windows.Forms.PictureBox();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBookF)).BeginInit();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siticonePanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePanel1.BorderRadius = 25;
            this.siticonePanel1.Controls.Add(this.btnDetail);
            this.siticonePanel1.Controls.Add(this.lblTitle);
            this.siticonePanel1.Controls.Add(this.pictureBookF);
            this.siticonePanel1.Location = new System.Drawing.Point(3, 3);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(188, 227);
            this.siticonePanel1.TabIndex = 0;
            // 
            // btnDetail
            // 
            this.btnDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetail.AutoRoundedCorners = true;
            this.btnDetail.BorderRadius = 16;
            this.btnDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDetail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDetail.ForeColor = System.Drawing.Color.White;
            this.btnDetail.Location = new System.Drawing.Point(7, 183);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(169, 35);
            this.btnDetail.TabIndex = 2;
            this.btnDetail.Text = "Detalhes";
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblTitle.Location = new System.Drawing.Point(0, 128);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(188, 54);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "label1";
            // 
            // pictureBookF
            // 
            this.pictureBookF.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBookF.Location = new System.Drawing.Point(0, 0);
            this.pictureBookF.Name = "pictureBookF";
            this.pictureBookF.Size = new System.Drawing.Size(188, 128);
            this.pictureBookF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBookF.TabIndex = 0;
            this.pictureBookF.TabStop = false;
            // 
            // FlowCardBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.siticonePanel1);
            this.MinimumSize = new System.Drawing.Size(196, 235);
            this.Name = "FlowCardBook";
            this.Size = new System.Drawing.Size(196, 235);
            this.Load += new System.EventHandler(this.FlowCardBook_Load);
            this.siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBookF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.PictureBox pictureBookF;
        private System.Windows.Forms.Label lblTitle;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnDetail;
    }
}
