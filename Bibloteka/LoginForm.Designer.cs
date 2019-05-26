namespace Bibloteka
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblMemberLogin = new System.Windows.Forms.Label();
            this.txtUsername = new Bunifu.Framework.UI.BunifuTextbox();
            this.pcBoxMainLogin = new System.Windows.Forms.PictureBox();
            this.bunifuElipseLoginForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.buElipsePicBox = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnCloseLoginForm = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxMainLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseLoginForm)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMemberLogin
            // 
            this.lblMemberLogin.AutoSize = true;
            this.lblMemberLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberLogin.ForeColor = System.Drawing.Color.White;
            this.lblMemberLogin.Location = new System.Drawing.Point(96, 199);
            this.lblMemberLogin.Name = "lblMemberLogin";
            this.lblMemberLogin.Size = new System.Drawing.Size(193, 29);
            this.lblMemberLogin.TabIndex = 0;
            this.lblMemberLogin.Text = "Kyçja ne sistem";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Silver;
            this.txtUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtUsername.BackgroundImage")));
            this.txtUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsername.Icon = ((System.Drawing.Image)(resources.GetObject("txtUsername.Icon")));
            this.txtUsername.Location = new System.Drawing.Point(57, 264);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(281, 52);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.text = "Nofka";
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            // 
            // pcBoxMainLogin
            // 
            this.pcBoxMainLogin.BackColor = System.Drawing.Color.GreenYellow;
            this.pcBoxMainLogin.Image = ((System.Drawing.Image)(resources.GetObject("pcBoxMainLogin.Image")));
            this.pcBoxMainLogin.Location = new System.Drawing.Point(120, 85);
            this.pcBoxMainLogin.Name = "pcBoxMainLogin";
            this.pcBoxMainLogin.Size = new System.Drawing.Size(134, 78);
            this.pcBoxMainLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBoxMainLogin.TabIndex = 5;
            this.pcBoxMainLogin.TabStop = false;
            // 
            // bunifuElipseLoginForm
            // 
            this.bunifuElipseLoginForm.ElipseRadius = 15;
            this.bunifuElipseLoginForm.TargetControl = this;
            // 
            // buElipsePicBox
            // 
            this.buElipsePicBox.ElipseRadius = 25;
            this.buElipsePicBox.TargetControl = this.pcBoxMainLogin;
            // 
            // btnCloseLoginForm
            // 
            this.btnCloseLoginForm.BackColor = System.Drawing.Color.Crimson;
            this.btnCloseLoginForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseLoginForm.Image")));
            this.btnCloseLoginForm.ImageActive = null;
            this.btnCloseLoginForm.Location = new System.Drawing.Point(335, 12);
            this.btnCloseLoginForm.Name = "btnCloseLoginForm";
            this.btnCloseLoginForm.Size = new System.Drawing.Size(37, 36);
            this.btnCloseLoginForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCloseLoginForm.TabIndex = 6;
            this.btnCloseLoginForm.TabStop = false;
            this.btnCloseLoginForm.Zoom = 10;
            this.btnCloseLoginForm.Click += new System.EventHandler(this.CloseLoginForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(57, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 52);
            this.panel1.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Silver;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(61, 12);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(217, 21);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.Text = "Fjalëkalimi";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnLogin.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Kyçu ";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnLogin.IdleForecolor = System.Drawing.Color.White;
            this.btnLogin.IdleLineColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(101, 490);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(181, 48);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(384, 610);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCloseLoginForm);
            this.Controls.Add(this.pcBoxMainLogin);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblMemberLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "Kyçja ne sistem";
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxMainLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseLoginForm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       // private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private System.Windows.Forms.Label lblMemberLogin;
        private Bunifu.Framework.UI.BunifuTextbox txtUsername;
        private System.Windows.Forms.PictureBox pcBoxMainLogin;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseLoginForm;
        private Bunifu.Framework.UI.BunifuElipse buElipsePicBox;
        private Bunifu.Framework.UI.BunifuImageButton btnCloseLoginForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
    }
}

