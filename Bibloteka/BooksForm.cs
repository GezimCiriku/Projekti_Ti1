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

        private void BooksForm_Load(object sender, EventArgs e)
        {
            //LibriBLL.SelectBooks(dgvBooks);

            //DataTable dt = new DataTable();
            //dt = KategoriaBLL.SelectKategories();
            //cmbKategoriaID.DataSource = dt;
            //cmbKategoriaID.DisplayMember = dt.Columns[1].ColumnName;
            //cmbKategoriaID.ValueMember = dt.Columns[0].ColumnName;

            //btnEdit.Enabled = false;
            //btnDelete.Enabled = false;
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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            Kategoria objK = new Kategoria(cmbKategoriaID.SelectedIndex + 1, cmbKategoriaID.Text);

            Libri objL = new Libri(int.Parse(txtLibriID.Text), txtTitulli.Text, txtISBN.Text,
                txtShtepiaBotuese.Text, txtGjuha.Text,
                objK, int.Parse(txtVitiBotimit.Text), int.Parse(txtNrKopjeve.Text));

            Autori objA = new Autori();
            objA.Emri = txtEmriAutori.Text;
            objA.Mbiemri = txtMbiemriAutori.Text;
            //kujdesu per AutoriID si parameter out

            Libri_Autori objLA = new Libri_Autori(objL, objA);

            try
            {
                if (AutoriBLL.InsertAutor(objA))
                {
                    LibriBLL.InsertBook(objL);
                }


                MessageBox.Show("Succesful Insert");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccesful Insert\n" + ex.Message);
                throw;
            }

            dgvBooks.DataSource = LibriDAL.GetBooks();
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
            txtEmriAutori.Text = dgvBooks.Rows[rowIndex].Cells[9].Value.ToString().Split(' ')[0];
            txtMbiemriAutori.Text = dgvBooks.Rows[rowIndex].Cells[9].Value.ToString().Split(' ')[1];

            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Kategoria objK = new Kategoria(cmbKategoriaID.SelectedIndex + 1, cmbKategoriaID.Text);

                Libri objL = new Libri(int.Parse(txtLibriID.Text), txtTitulli.Text, txtISBN.Text,
                    txtShtepiaBotuese.Text, txtGjuha.Text,
                    objK, int.Parse(txtVitiBotimit.Text), int.Parse(txtNrKopjeve.Text));

              //  objL.AutoriID = int.Parse(txtAutoriID.Text);

                if (LibriBLL.Edit(objL))
                {
                    MessageBox.Show("Updated Succesfuly");
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
           // int AutoriID = int.Parse(txtAutoriID.Text);

            //if (LibriBLL.Delete(LibriID, AutoriID))
            //{
            //    MessageBox.Show("Delete sucessfully");
            //    Clear();
            //    btnDelete.Enabled = false;

            //}
            //else
            //{
            //    MessageBox.Show("Delete failed");
            //}

            LibriBLL.SelectBooks(dgvBooks);
        }
    }
}
