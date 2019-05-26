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

        private void btnHome_Click(object sender, EventArgs e)
        {
            home_Control1.Visible = true;
            SidePanel.Top = btnHome.Top;
          //  crudBooks_Control1.Visible = false;
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {

            home_Control1.Visible = false;
            SidePanel.Top = btnBooks.Top;
            BooksForm bf = new BooksForm();
            bf.Show();
            //crudBooks_Control1.Visible = true;
        }
        
        private void btnReaders_Click(object sender, EventArgs e)
        {
            home_Control1.Visible = false;
            SidePanel.Top = btnReaders.Top;
          //  crudBooks_Control1.Visible = false;
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            home_Control1.Visible = false;
            SidePanel.Top = btnStaff.Top;
          //  crudBooks_Control1.Visible = false;
        }

        private void btnLocations_Click(object sender, EventArgs e)
        {
            home_Control1.Visible = false;
            SidePanel.Top = btnLocations.Top;
          //  crudBooks_Control1.Visible = false;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnLogOut.Top;

            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            home_Control1.Visible = false;
            SidePanel.Top = btnViewProfile.Top;
         //   crudBooks_Control1.Visible = false;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
         //   crudBooks_Control1.Visible = false;
        }

        private void btnCloseMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoans_Click(object sender, EventArgs e)
        {
            home_Control1.Visible = false;
            SidePanel.Top = btnLoans.Top;
         //   crudBooks_Control1.Visible = false;
        }
  
    }
}
