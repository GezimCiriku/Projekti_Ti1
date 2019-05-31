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
    public partial class Issue_ReturnForm : Form
    {
        public Issue_ReturnForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Issue_ReturnForm_Load(object sender, EventArgs e)
        {
            LibriBLL.SelectBooks(dgvBooks);
            PjesemarresiBLL.SelectPm(dgvReaders,3);
        }

        private void txtSearchReaders_KeyUp(object sender, KeyEventArgs e)
        {
            string search = txtSearchReaders.Text;

            PjesemarresiBLL.SearchPm(dgvReaders, search, 3);

            if (search == "")
            {
                PjesemarresiBLL.SelectPm(dgvReaders, 3);
            }
        }

        private void txtSearchBook_KeyUp(object sender, KeyEventArgs e)
        {
            string search = txtSearchBook.Text;

            LibriBLL.SearchBooks(dgvBooks, search);

            if (search == "")
            {
                LibriBLL.SelectBooks(dgvBooks);
            }
        }
    }
}
