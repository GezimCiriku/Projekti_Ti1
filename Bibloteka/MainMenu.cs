using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bibloteka
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        BooksForm bf = new BooksForm();
        ReadersForm rf = new ReadersForm();

        private void btnHome_Click(object sender, EventArgs e)
        {
            home_Control1.Visible = true;
            SidePanel.Top = btnHome.Top;
            bf.Hide();
            rf.Hide();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            home_Control1.Visible = false;
            SidePanel.Top = btnBooks.Top;    
            bf.Show();
            bf.Focus();
            rf.Hide();
        }
        
        private void btnReaders_Click(object sender, EventArgs e)
        {
            home_Control1.Visible = false;
            SidePanel.Top = btnReaders.Top;
            bf.Hide();
            rf.Show();
            rf.Focus();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            home_Control1.Visible = false;
            SidePanel.Top = btnStaff.Top;
            bf.Hide();
            rf.Hide();
        }

        private void btnLocations_Click(object sender, EventArgs e)
        {
            home_Control1.Visible = false;
            SidePanel.Top = btnLocations.Top;
            bf.Hide();
            rf.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnLogOut.Top;

            this.Hide();
            bf.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            home_Control1.Visible = false;
            SidePanel.Top = btnViewProfile.Top;
            bf.Hide();
            rf.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
         
        }

        private void btnCloseMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            bf.Close();
            rf.Close();
        }

        private void btnLoans_Click(object sender, EventArgs e)
        {
            home_Control1.Visible = false;
            SidePanel.Top = btnLoans.Top;
            bf.Hide();
            rf.Hide();
        }
  
    }
}
