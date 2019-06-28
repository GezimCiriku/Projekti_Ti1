using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibloteka.BLL;
using System.Threading;
using System.Reflection;
using System.Resources;
using System.Globalization;


namespace Bibloteka
{
    public partial class LoginForm : Form
    {

        public static bool albFlag { get; set; } = true;

        public LoginForm()
        {
            InitializeComponent();
        }

        public static string   UserInUse { get; set; }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.ForeColor = Color.Black;
            txtPassword.PasswordChar = '*';
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.text = "";
            txtUsername.ForeColor = Color.Black;
        }

        private void CloseLoginForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (PjesemarresiBLL.CheckLogin(txtUsername.text, txtPassword.Text))
            {
                UserInUse = txtUsername.text;

                this.Hide();
                MainMenu main = new MainMenu();
                main.Closed += (s, args) => this.Close();
                main.Show();
            }
            else
            {
                if (albFlag)
                {
                    MessageBox.Show("Kredenciale te gabuara, ju lutem provoni perseri!");
                }
                else
                {
                    MessageBox.Show("Username or Password is incorect, please try again!");
                }

                txtUsername.text = "";
                txtPassword.Text = "";
            }
        }

        private void btnEngLang_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("al-AL");
            CultureInfo ci = new CultureInfo("en-US");
            Assembly a = Assembly.Load("Bibloteka");
            ResourceManager rm = new ResourceManager("Bibloteka.Lang.langRes", a);

            lblMemberLogin.Text = rm.GetString("lblLogin", ci);
            txtUsername.text = rm.GetString("txtUsername", ci);
            txtPassword.Text = rm.GetString("txtPassword", ci);
            btnLogin.ButtonText = rm.GetString("btnLogin", ci);

            albFlag = false;
        }

        private void btnAlbLang_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            CultureInfo ci = new CultureInfo("al-AL");
            Assembly a = Assembly.Load("Bibloteka");
            ResourceManager rm = new ResourceManager("Bibloteka.Lang.langRes", a);

            lblMemberLogin.Text = rm.GetString("lblLogin", ci);
            txtUsername.text = rm.GetString("txtUsername", ci);
            txtPassword.Text = rm.GetString("txtPassword", ci);
            btnLogin.ButtonText = rm.GetString("btnLogin", ci);

            albFlag = true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            albFlag = true;
        }
    }
}
