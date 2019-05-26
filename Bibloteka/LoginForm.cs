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


namespace Bibloteka
{
    public partial class LoginForm : Form
    {
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
                MessageBox.Show("Kredenciale te gabuara, ju lutem provoni perseri");

                txtUsername.text = "";
                txtPassword.Text = "";
            }
        }
    }
}
