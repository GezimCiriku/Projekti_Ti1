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
    public partial class ReadersForm : Form
    {
        public ReadersForm()
        {
            InitializeComponent();
        }

        private void ReadersForm_Load(object sender, EventArgs e)
        {
            PjesemarresiBLL.SelectPm(dgvReaders);
            dgvReaders.Columns[1].Visible = false;

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnShto.Enabled = false;
        }

        public void Clear()
        {
            txtID.Text = "";
            txtEmri.Text = "";
            txtMbiemri.Text = "";
            txtNrTel.Text = "";
            txtEmail.Text = "";
            txtFjalekalimi.Text = "";
            txtNofka.Text = "";
           
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnShto.Enabled = false;
        }

        private void btnShto_Click(object sender, EventArgs e)
        {

            Pjesemarresit pm = new Pjesemarresit(0, 3, txtEmri.Text, txtMbiemri.Text, txtNrTel.Text, txtEmail.Text, txtNofka.Text, txtFjalekalimi.Text);
            pm.DataRegjistrimit = dtpDateRregj.Value;

            try
            {
                pm.PmID = PjesemarresiBLL.ShtoLexues(pm);
                MessageBox.Show("Succesful Insert");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccesful Insert\n" + ex.Message);
                throw;
            }
            PjesemarresiBLL.SelectPm(dgvReaders);
            Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgvReaders_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtID.Text = dgvReaders.Rows[rowIndex].Cells[0].Value.ToString();
            //  txtEmri.Text = dgvBooks.Rows[rowIndex].Cells[1].Value.ToString();
            txtEmri.Text = dgvReaders.Rows[rowIndex].Cells[2].Value.ToString();
            txtMbiemri.Text = dgvReaders.Rows[rowIndex].Cells[3].Value.ToString();
            txtNrTel.Text = dgvReaders.Rows[rowIndex].Cells[4].Value.ToString();
            txtEmail.Text = dgvReaders.Rows[rowIndex].Cells[5].Value.ToString();
            dtpDateRregj.Value =Convert.ToDateTime(dgvReaders.Rows[rowIndex].Cells[8].Value.ToString());
            txtNofka.Text = dgvReaders.Rows[rowIndex].Cells[6].Value.ToString();
            txtFjalekalimi.Text = dgvReaders.Rows[rowIndex].Cells[7].Value.ToString();
         



            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnShto.Enabled = false;
        }
    }
}
