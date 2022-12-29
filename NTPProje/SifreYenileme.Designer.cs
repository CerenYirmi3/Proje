namespace NTPProje
{
    partial class SifreYenileme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreYenileme));
            this.panelMail = new Guna.UI2.WinForms.Guna2Panel();
            this.txtMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnMail = new Guna.UI2.WinForms.Guna2Button();
            this.panelYeniSifre = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureGizle = new System.Windows.Forms.PictureBox();
            this.pictureGoster = new System.Windows.Forms.PictureBox();
            this.btnSifre = new Guna.UI2.WinForms.Guna2Button();
            this.txtSifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtKod = new Guna.UI2.WinForms.Guna2TextBox();
            this.ElipseSifreYenileme = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ElipspanelMail = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ElipsepanelYeniSifre = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnCikis = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panelMail.SuspendLayout();
            this.panelYeniSifre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGizle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMail
            // 
            this.panelMail.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelMail.Controls.Add(this.txtMail);
            this.panelMail.Controls.Add(this.btnMail);
            this.panelMail.Location = new System.Drawing.Point(113, 67);
            this.panelMail.Name = "panelMail";
            this.panelMail.ShadowDecoration.Parent = this.panelMail;
            this.panelMail.Size = new System.Drawing.Size(234, 200);
            this.panelMail.TabIndex = 9;
            // 
            // txtMail
            // 
            this.txtMail.AutoRoundedCorners = true;
            this.txtMail.BorderRadius = 17;
            this.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.DefaultText = "Mail Adresi";
            this.txtMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMail.DisabledState.Parent = this.txtMail;
            this.txtMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMail.FocusedState.Parent = this.txtMail;
            this.txtMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMail.HoverState.Parent = this.txtMail;
            this.txtMail.Location = new System.Drawing.Point(17, 72);
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.PlaceholderText = "";
            this.txtMail.SelectedText = "";
            this.txtMail.SelectionStart = 11;
            this.txtMail.ShadowDecoration.Parent = this.txtMail;
            this.txtMail.Size = new System.Drawing.Size(200, 36);
            this.txtMail.TabIndex = 11;
            this.txtMail.Enter += new System.EventHandler(this.txtMail_Enter);
            this.txtMail.Leave += new System.EventHandler(this.txtMail_Leave);
            // 
            // btnMail
            // 
            this.btnMail.AutoRoundedCorners = true;
            this.btnMail.BorderRadius = 18;
            this.btnMail.CheckedState.Parent = this.btnMail;
            this.btnMail.CustomImages.Parent = this.btnMail;
            this.btnMail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMail.ForeColor = System.Drawing.Color.White;
            this.btnMail.HoverState.Parent = this.btnMail;
            this.btnMail.Location = new System.Drawing.Point(17, 132);
            this.btnMail.Name = "btnMail";
            this.btnMail.ShadowDecoration.Parent = this.btnMail;
            this.btnMail.Size = new System.Drawing.Size(200, 38);
            this.btnMail.TabIndex = 10;
            this.btnMail.Text = "Aktivasyon Kodunu Gönder";
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // panelYeniSifre
            // 
            this.panelYeniSifre.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelYeniSifre.Controls.Add(this.pictureGizle);
            this.panelYeniSifre.Controls.Add(this.pictureGoster);
            this.panelYeniSifre.Controls.Add(this.btnSifre);
            this.panelYeniSifre.Controls.Add(this.txtSifre);
            this.panelYeniSifre.Controls.Add(this.txtKod);
            this.panelYeniSifre.Location = new System.Drawing.Point(377, 67);
            this.panelYeniSifre.Name = "panelYeniSifre";
            this.panelYeniSifre.ShadowDecoration.Parent = this.panelYeniSifre;
            this.panelYeniSifre.Size = new System.Drawing.Size(312, 200);
            this.panelYeniSifre.TabIndex = 10;
            // 
            // pictureGizle
            // 
            this.pictureGizle.Image = ((System.Drawing.Image)(resources.GetObject("pictureGizle.Image")));
            this.pictureGizle.Location = new System.Drawing.Point(255, 83);
            this.pictureGizle.Name = "pictureGizle";
            this.pictureGizle.Size = new System.Drawing.Size(30, 25);
            this.pictureGizle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureGizle.TabIndex = 11;
            this.pictureGizle.TabStop = false;
            this.pictureGizle.Click += new System.EventHandler(this.pictureGizle_Click);
            // 
            // pictureGoster
            // 
            this.pictureGoster.Image = ((System.Drawing.Image)(resources.GetObject("pictureGoster.Image")));
            this.pictureGoster.Location = new System.Drawing.Point(255, 83);
            this.pictureGoster.Name = "pictureGoster";
            this.pictureGoster.Size = new System.Drawing.Size(30, 25);
            this.pictureGoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureGoster.TabIndex = 10;
            this.pictureGoster.TabStop = false;
            this.pictureGoster.Visible = false;
            this.pictureGoster.Click += new System.EventHandler(this.pictureGoster_Click);
            // 
            // btnSifre
            // 
            this.btnSifre.AutoRoundedCorners = true;
            this.btnSifre.BorderRadius = 18;
            this.btnSifre.CheckedState.Parent = this.btnSifre;
            this.btnSifre.CustomImages.Parent = this.btnSifre;
            this.btnSifre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSifre.ForeColor = System.Drawing.Color.White;
            this.btnSifre.HoverState.Parent = this.btnSifre;
            this.btnSifre.Location = new System.Drawing.Point(35, 132);
            this.btnSifre.Name = "btnSifre";
            this.btnSifre.ShadowDecoration.Parent = this.btnSifre;
            this.btnSifre.Size = new System.Drawing.Size(200, 39);
            this.btnSifre.TabIndex = 9;
            this.btnSifre.Text = "Şifreyi Değiştir";
            this.btnSifre.Click += new System.EventHandler(this.btnSifre_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.AutoRoundedCorners = true;
            this.txtSifre.BorderRadius = 17;
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifre.DefaultText = "Yeni Şifre";
            this.txtSifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSifre.DisabledState.Parent = this.txtSifre;
            this.txtSifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSifre.FocusedState.Parent = this.txtSifre;
            this.txtSifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSifre.HoverState.Parent = this.txtSifre;
            this.txtSifre.Location = new System.Drawing.Point(35, 78);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '\0';
            this.txtSifre.PlaceholderText = "";
            this.txtSifre.SelectedText = "";
            this.txtSifre.SelectionStart = 10;
            this.txtSifre.ShadowDecoration.Parent = this.txtSifre;
            this.txtSifre.Size = new System.Drawing.Size(200, 36);
            this.txtSifre.TabIndex = 8;
            this.txtSifre.Load += new System.EventHandler(this.txtSifre_Leave);
            this.txtSifre.Enter += new System.EventHandler(this.txtSifre_Enter);
            // 
            // txtKod
            // 
            this.txtKod.AutoRoundedCorners = true;
            this.txtKod.BorderRadius = 17;
            this.txtKod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKod.DefaultText = "Aktivasyon Kodu";
            this.txtKod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKod.DisabledState.Parent = this.txtKod;
            this.txtKod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKod.FocusedState.Parent = this.txtKod;
            this.txtKod.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKod.HoverState.Parent = this.txtKod;
            this.txtKod.Location = new System.Drawing.Point(35, 28);
            this.txtKod.Name = "txtKod";
            this.txtKod.PasswordChar = '\0';
            this.txtKod.PlaceholderText = "";
            this.txtKod.SelectedText = "";
            this.txtKod.SelectionStart = 15;
            this.txtKod.ShadowDecoration.Parent = this.txtKod;
            this.txtKod.Size = new System.Drawing.Size(200, 36);
            this.txtKod.TabIndex = 7;
            this.txtKod.Enter += new System.EventHandler(this.txtKod_Enter);
            this.txtKod.Leave += new System.EventHandler(this.txtKod_Leave);
            // 
            // ElipseSifreYenileme
            // 
            this.ElipseSifreYenileme.BorderRadius = 35;
            this.ElipseSifreYenileme.TargetControl = this;
            // 
            // ElipspanelMail
            // 
            this.ElipspanelMail.BorderRadius = 35;
            this.ElipspanelMail.TargetControl = this.panelMail;
            // 
            // ElipsepanelYeniSifre
            // 
            this.ElipsepanelYeniSifre.BorderRadius = 35;
            this.ElipsepanelYeniSifre.TargetControl = this.panelYeniSifre;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-5, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(96, 66);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // btnCikis
            // 
            this.btnCikis.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnCikis.CheckedState.Parent = this.btnCikis;
            this.btnCikis.HoverState.ImageSize = new System.Drawing.Size(33, 37);
            this.btnCikis.HoverState.Parent = this.btnCikis;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.ImageRotate = 0F;
            this.btnCikis.ImageSize = new System.Drawing.Size(31, 35);
            this.btnCikis.Location = new System.Drawing.Point(685, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.PressedState.ImageOffset = new System.Drawing.Point(2, 2);
            this.btnCikis.PressedState.ImageSize = new System.Drawing.Size(33, 37);
            this.btnCikis.PressedState.Parent = this.btnCikis;
            this.btnCikis.Size = new System.Drawing.Size(50, 45);
            this.btnCikis.TabIndex = 7;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // ŞifreYenileme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(747, 302);
            this.Controls.Add(this.panelYeniSifre);
            this.Controls.Add(this.panelMail);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnCikis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ŞifreYenileme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ŞifreYenileme";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ŞifreYenileme_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ŞifreYenileme_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ŞifreYenileme_MouseUp);
            this.panelMail.ResumeLayout(false);
            this.panelYeniSifre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureGizle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton btnCikis;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2Panel panelMail;
        private Guna.UI2.WinForms.Guna2TextBox txtMail;
        private Guna.UI2.WinForms.Guna2Button btnMail;
        private Guna.UI2.WinForms.Guna2Panel panelYeniSifre;
        private System.Windows.Forms.PictureBox pictureGizle;
        private System.Windows.Forms.PictureBox pictureGoster;
        private Guna.UI2.WinForms.Guna2Button btnSifre;
        private Guna.UI2.WinForms.Guna2TextBox txtSifre;
        private Guna.UI2.WinForms.Guna2TextBox txtKod;
        private Guna.UI2.WinForms.Guna2Elipse ElipseSifreYenileme;
        private Guna.UI2.WinForms.Guna2Elipse ElipspanelMail;
        private Guna.UI2.WinForms.Guna2Elipse ElipsepanelYeniSifre;
    }
}