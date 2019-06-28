using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Bibloteka
{
    public partial class MainMenu : Form
    {
        CultureInfo current = Thread.CurrentThread.CurrentUICulture;
        Assembly a = Assembly.Load("Bibloteka");
      
        bool albFlag = LoginForm.albFlag;

        public MainMenu()
        {
            InitializeComponent();
            ResourceManager rm = new ResourceManager("Bibloteka.Lang.langRes", a);

            if (!albFlag)
            {
                CultureInfo ci = new CultureInfo("en-US");
                btnHome.Text= rm.GetString("btnHome", ci);
                btnViewProfile.Text = rm.GetString("btnMyProfile", ci);
                btnBooks.Text = rm.GetString("btnBooks", ci);
                btnReaders.Text = rm.GetString("btnReaders", ci);
                btnStaff.Text = rm.GetString("btnStaff", ci);
                btnLoans.Text = rm.GetString("btnLoans", ci);
                btnLogOut.Text = rm.GetString("btnLogOut", ci);
                lblBibloteka.Text = rm.GetString("lblBibloteka", ci);
            }
        }



        BooksForm bf = new BooksForm();
        ReadersForm rf = new ReadersForm();
        StaffForm sf = new StaffForm();
        HomeForm hf = new HomeForm();
        MyProfile mp = new MyProfile();
        LoansForm lf = new LoansForm();
       

        private void btnHome_Click(object sender, EventArgs e)
        {
            
            SidePanel.Top = btnHome.Top;
            bf.Hide();
            rf.Hide();
            sf.Hide();
            hf.Show();
            hf.Focus();
            mp.Hide();
            lf.Hide();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
          
            SidePanel.Top = btnBooks.Top;    
            bf.Show();
            bf.Focus();
            rf.Hide();
            sf.Hide();
            hf.Hide();
            mp.Hide();
            lf.Hide();
        }
        
        private void btnReaders_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnReaders.Top;
            bf.Hide();
            rf.Show();
            rf.Focus();
            sf.Hide();
            hf.Hide();
            mp.Hide();
            lf.Hide();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {  
            SidePanel.Top = btnStaff.Top;
            bf.Hide();
            rf.Hide();
            sf.Show();
            sf.Focus();
            hf.Hide();
            mp.Hide();
            lf.Hide();
        }


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnLogOut.Top;

            this.Hide();
            bf.Close();
            rf.Close();
            sf.Close();
            lf.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            
            SidePanel.Top = btnViewProfile.Top;
            bf.Hide();
            rf.Hide();
            sf.Hide();
            hf.Hide();
            mp.Show();
            mp.Focus();
            lf.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
          
            
        }

        private void btnCloseMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            bf.Close();
            rf.Close();
            sf.Close();
            hf.Close();
            mp.Close();
            lf.Close();        
        }

        private void btnLoans_Click(object sender, EventArgs e)
        {
            hf.Hide();
            SidePanel.Top = btnLoans.Top;
            bf.Hide();
            rf.Hide();
            sf.Hide();
            mp.Hide();
            lf.Show();
            lf.Focus();       
        }
  
    }
}
