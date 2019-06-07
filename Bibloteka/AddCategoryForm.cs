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
    public partial class AddCategoryForm : Form
    {
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            Kategoria kat = new Kategoria();
            kat.Pershkrimi = txtKategoria.Text;

            if (KategoriaBLL.InsertCategory(kat))
            {
                MessageBox.Show("Kategoria u shtua me sukses");
                KategoriaBLL.SelectCategories(dgvCategories);
            } 
            else
            {
                MessageBox.Show("Kjo Kategori ekziston!");
            }
        }

        private void AddCategoryForm_Load(object sender, EventArgs e)
        {
            KategoriaBLL.SelectCategories(dgvCategories);
        }

        private void dgvCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtID.Text = dgvCategories.Rows[rowIndex].Cells[0].Value.ToString();
            txtKategoria.Text = dgvCategories.Rows[rowIndex].Cells[1].Value.ToString();
           
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int KategoriaID = int.Parse(txtID.Text);

            if (KategoriaBLL.Delete(KategoriaID))
            {
                MessageBox.Show("Delete sucessfully");

                txtID.Text = "";
                txtKategoria.Text = "";
            }
            else
            {
                MessageBox.Show("Delete failed");
            }

            KategoriaBLL.SelectCategories(dgvCategories);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
