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
            this.btnAlbLang = new System.Windows.Forms.Button();
            this.btnEngLang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxMainLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseLoginForm)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMemberLogin
            // 
            resources.ApplyResources(this.lblMemberLogin, "lblMemberLogin");
            this.lblMemberLogin.ForeColor = System.Drawing.Color.White;
            this.lblMemberLogin.Name = "lblMemberLogin";
            // 
            // txtUsername
            // 
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.txtUsername.BackColor = System.Drawing.Color.Silver;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsername.Icon = ((System.Drawing.Image)(resources.GetObject("txtUsername.Icon")));
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.text = "Nofka";
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            // 
            // pcBoxMainLogin
            // 
            resources.ApplyResources(this.pcBoxMainLogin, "pcBoxMainLogin");
            this.pcBoxMainLogin.BackColor = System.Drawing.Color.GreenYellow;
            this.pcBoxMainLogin.Name = "pcBoxMainLogin";
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
            resources.ApplyResources(this.btnCloseLoginForm, "btnCloseLoginForm");
            this.btnCloseLoginForm.BackColor = System.Drawing.Color.Crimson;
            this.btnCloseLoginForm.ImageActive = null;
            this.btnCloseLoginForm.Name = "btnCloseLoginForm";
            this.btnCloseLoginForm.TabStop = false;
            this.btnCloseLoginForm.Zoom = 10;
            this.btnCloseLoginForm.Click += new System.EventHandler(this.CloseLoginForm_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Name = "panel1";
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.BackColor = System.Drawing.Color.Silver;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // btnLogin
            // 
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnLogin.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnLogin.ButtonText = "Kyçu ";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnLogin.IdleForecolor = System.Drawing.Color.White;
            this.btnLogin.IdleLineColor = System.Drawing.Color.White;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnAlbLang
            // 
            resources.ApplyResources(this.btnAlbLang, "btnAlbLang");
            this.btnAlbLang.Name = "btnAlbLang";
            this.btnAlbLang.UseVisualStyleBackColor = true;
            this.btnAlbLang.Click += new System.EventHandler(this.btnAlbLang_Click);
            // 
            // btnEngLang
            // 
            resources.ApplyResources(this.btnEngLang, "btnEngLang");
            this.btnEngLang.Name = "btnEngLang";
            this.btnEngLang.UseVisualStyleBackColor = true;
            this.btnEngLang.Click += new System.EventHandler(this.btnEngLang_Click);
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.btnEngLang);
            this.Controls.Add(this.btnAlbLang);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCloseLoginForm);
            this.Controls.Add(this.pcBoxMainLogin);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblMemberLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
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
        private System.Windows.Forms.Button btnEngLang;
        private System.Windows.Forms.Button btnAlbLang;
    }
}

