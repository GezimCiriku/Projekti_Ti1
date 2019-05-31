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

namespace Bibloteka
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            lblTotalBooks.Text = LibriBLL.CountBooks().ToString();

            lblReturnedBooks.Text = (int.Parse(lblTotalBooks.Text) - int.Parse(lblIssuedBooks.Text)).ToString();
        }
    }
}
