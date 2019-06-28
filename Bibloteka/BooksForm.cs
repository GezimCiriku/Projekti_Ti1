using Bibloteka.BLL;
using Bibloteka.BO;
using Bibloteka.DAL;
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
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
        }

        string txtAutoriId;

        private void BooksForm_Load(object sender, EventArgs e)
        {
            LibriBLL.SelectBooks(dgvBooks);

            DataTable dt = new DataTable();
            dt = KategoriaBLL.SelectKategories();
            cmbKategoriaID.DataSource = dt;
            cmbKategoriaID.DisplayMember = dt.Columns[1].ColumnName;
            cmbKategoriaID.ValueMember = dt.Columns[0].ColumnName;


            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnShto.Enabled = false;
        }

        public void Clear()
        {
            txtLibriID.Text = "";
            txtTitulli.Text = "";
            txtISBN.Text = "";
            txtShtepiaBotuese.Text = "";
            txtGjuha.Text = "";
            cmbKategoriaID.Text = "";
            txtVitiBotimit.Text = "";
            txtNrKopjeve.Text = "";
            txtEmriAutori.Text = "";
            txtMbiemriAutori.Text = "";

            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnShto.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            Kategoria objK = new Kategoria(cmbKategoriaID.SelectedIndex + 1, cmbKategoriaID.Text);

            Libri objL = new Libri(0, txtTitulli.Text, txtISBN.Text,
                txtShtepiaBotuese.Text, txtGjuha.Text,
                objK, int.Parse(txtVitiBotimit.Text), int.Parse(txtNrKopjeve.Text));

            Autori objA = new Autori();
            objA.Emri = txtEmriAutori.Text;
            objA.Mbiemri = txtMbiemriAutori.Text;

            Libri_Autori objLA = new Libri_Autori(objL, objA);

            try
            {
                objL.AutoriID = AutoriBLL.InsertAutor(objA);
                objL.LibriID = LibriBLL.InsertBook(objL);
                txtLibriID.Text = objL.LibriID.ToString();

                if (objL.LibriID == 0)
                {
                    MessageBox.Show("Nuk mund te shtoni dy libra me ISBN te njejte");
                }
                else
                {
                    MessageBox.Show("Libri u shtua me sukses");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Shtimi i librit deshtoi\n" + ex.Message);
                throw;
            }

            LibriBLL.SelectBooks(dgvBooks);
            Clear();
        }

        private void dgvBooks_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtLibriID.Text = dgvBooks.Rows[rowIndex].Cells[0].Value.ToString();
            txtTitulli.Text = dgvBooks.Rows[rowIndex].Cells[1].Value.ToString();
            txtISBN.Text = dgvBooks.Rows[rowIndex].Cells[2].Value.ToString();
            txtShtepiaBotuese.Text = dgvBooks.Rows[rowIndex].Cells[3].Value.ToString();
            txtGjuha.Text = dgvBooks.Rows[rowIndex].Cells[4].Value.ToString();
            cmbKategoriaID.Text = dgvBooks.Rows[rowIndex].Cells[5].Value.ToString();
            txtVitiBotimit.Text = dgvBooks.Rows[rowIndex].Cells[6].Value.ToString();
            txtNrKopjeve.Text = dgvBooks.Rows[rowIndex].Cells[7].Value.ToString();
            txtAutoriId = dgvBooks.Rows[rowIndex].Cells[8].Value.ToString();
            txtEmriAutori.Text = dgvBooks.Rows[rowIndex].Cells[9].Value.ToString().Split(' ')[0];
            txtMbiemriAutori.Text = dgvBooks.Rows[rowIndex].Cells[9].Value.ToString().Split(' ')[1];

            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnShto.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Kategoria objK = new Kategoria(cmbKategoriaID.SelectedIndex + 1, cmbKategoriaID.Text);

                Libri objL = new Libri(int.Parse(txtLibriID.Text), txtTitulli.Text, txtISBN.Text,
                    txtShtepiaBotuese.Text, txtGjuha.Text,
                    objK, int.Parse(txtVitiBotimit.Text), int.Parse(txtNrKopjeve.Text));

                objL.AutoriID = int.Parse(txtAutoriId);

                Autori autor = new Autori();
                autor.AutoriID = objL.AutoriID;
                autor.Emri = txtEmriAutori.Text;
                autor.Mbiemri = txtMbiemriAutori.Text;

                if (LibriBLL.Edit(objL, autor))
                {
                    MessageBox.Show("Updated Succesfuly");
                    Clear();
                    LibriBLL.SelectBooks(dgvBooks);
                }
                else
                {
                    MessageBox.Show("Updated Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int LibriID = int.Parse(txtLibriID.Text);
            int AutoriID = int.Parse(txtAutoriId);

            if (LibriBLL.Delete(LibriID, AutoriID))
            {
                MessageBox.Show("Delete sucessfully");
                Clear();
            }
            else
            {
                MessageBox.Show("Delete failed");
            }

            LibriBLL.SelectBooks(dgvBooks);
        }

        private void txtLibriID_TextChanged(object sender, EventArgs e)
        {
            btnShto.Enabled = true;
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string search = txtSearch.Text;

            LibriBLL.SearchBooks(dgvBooks, search);

            if (search == "")
            {
                LibriBLL.SelectBooks(dgvBooks);
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategoryForm acf = new AddCategoryForm();
            acf.ShowDialog();
        }

        private void cmbKategoriaID_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = KategoriaBLL.SelectKategories();
            cmbKategoriaID.DataSource = dt;
            cmbKategoriaID.DisplayMember = dt.Columns[1].ColumnName;
            cmbKategoriaID.ValueMember = dt.Columns[0].ColumnName;
        }

        private void dgvBooks_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void txtVitiBotimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTitulli_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar));
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file:\\C:\\Users\\hp\\Desktop\\Projekti_Ti1\\helpi.chm", HelpNavigator.Topic, "Forma4.htm");
        }
    }
}
