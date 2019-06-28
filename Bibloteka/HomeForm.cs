using Bibloteka.BLL;
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
    public partial class HomeForm : Form
    {
        CultureInfo current = Thread.CurrentThread.CurrentUICulture;
        Assembly a = Assembly.Load("Bibloteka");

        bool albFlag = LoginForm.albFlag;

        public HomeForm()
        {
            InitializeComponent();
            ResourceManager rm = new ResourceManager("Bibloteka.Lang.langRes", a);

            if (!albFlag)
            {
                CultureInfo ci = new CultureInfo("en-US");
                label1.Text = rm.GetString("label1", ci);
                label2.Text = rm.GetString("label2", ci);
                label3.Text = rm.GetString("label3", ci);
                label4.Text = rm.GetString("label4", ci);
                label6.Text = rm.GetString("label6", ci);
                label8.Text = rm.GetString("label8", ci);
                lblReports.Text = rm.GetString("lblReports", ci);
                label10.Text = rm.GetString("label10", ci);
                lblMembers.Text = rm.GetString("lblMembers", ci);
            }
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void HomeForm_Activated(object sender, EventArgs e)
        {
            lblTotalBooks.Text = LibriBLL.CountBooks().ToString();
            lblIssuedBooks.Text = LibriBLL.CountHuazimet().ToString();
            lblReturnedBooks.Text = LibriBLL.CountKthimet().ToString();

            lblTotalMembers1.Text = PjesemarresiBLL.CountMembers().ToString();
            lblReaders.Text = PjesemarresiBLL.CountReaders().ToString();
        }
    }
}
