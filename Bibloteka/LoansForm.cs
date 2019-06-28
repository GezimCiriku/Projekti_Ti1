using Bibloteka.BLL;
using Bibloteka.BO;
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
    public partial class LoansForm : Form
    {
        public LoansForm()
        {
            InitializeComponent();
        }

        Issue_ReturnForm IR = new Issue_ReturnForm();

        private void btnShto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Issue_ReturnForm IR = new Issue_ReturnForm();
            IR.Show();

            //Issue_ReturnForm IR = new Issue_ReturnForm();
            //IR.Show();
        }

        private void LoansForm_Load(object sender, EventArgs e)
        {
            dgvHuazimet.Visible = true;
            dgvHuazimetDetajet.Visible = false;
            HuazimetBLL.SelectHuazimet(dgvHuazimet);
        }

        private void btnShikoDetajet_Click(object sender, EventArgs e)
        {
            dgvHuazimet.Visible = false;
            dgvHuazimetDetajet.Visible = true;
            HuazimetBLL.SelectHuazimetDetajet(dgvHuazimetDetajet);
        }

        private void txtSearchReaders_KeyUp(object sender, KeyEventArgs e)
        {
            string search = txtSearchHuazime.Text;

            HuazimetBLL.SearchHuazimet(dgvHuazimet, search);

            if (search == "")
            {
                HuazimetBLL.SelectHuazimet(dgvHuazimet);
            }
        }

        private void LoansForm_Activated(object sender, EventArgs e)
        {
            dgvHuazimet.Visible = true;
            dgvHuazimetDetajet.Visible = false;
            HuazimetBLL.SelectHuazimet(dgvHuazimet);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file:\\C:\\Users\\hp\\Desktop\\Projekti_Ti1\\helpi.chm", HelpNavigator.Topic, "Forma5.htm");
        }
    }
}
