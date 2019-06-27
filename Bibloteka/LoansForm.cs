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
            Issue_ReturnForm IR = new Issue_ReturnForm();
            IR.Show();
        }

        private void LoansForm_Load(object sender, EventArgs e)
        {
            dgvHuazimetDetajet.Visible = false;
            HuazimetBLL.SelectHuazimet(dgvHuazimet);
        }

        private void btnShikoDetajet_Click(object sender, EventArgs e)
        {
            dgvHuazimet.Visible = false;
            dgvHuazimetDetajet.Visible = true;
            HuazimetBLL.SelectHuazimetDetajet(dgvHuazimetDetajet);
        }
    }
}
