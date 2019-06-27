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
    public partial class Issue_ReturnForm : Form
    {
        public Issue_ReturnForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            LoansForm loansForm = new LoansForm();
            loansForm.Show();
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

        private void dgvReaders_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            lblPmID1.Text = dgvReaders.Rows[rowIndex].Cells[0].Value.ToString();
            lblLexuesi1.Text = dgvReaders.Rows[rowIndex].Cells[2].Value.ToString()+" "+ dgvReaders.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void dgvBooks_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            lblLibriID1.Text = dgvBooks.Rows[rowIndex].Cells[0].Value.ToString();
            lblLibri1.Text = dgvBooks.Rows[rowIndex].Cells[1].Value.ToString();
            lblNumriKopjeve1.Text = dgvBooks.Rows[rowIndex].Cells[7].Value.ToString();
        }

        private void btnHuazo_Click(object sender, EventArgs e)
        {
            int nrKopjeve = int.Parse(lblNumriKopjeve1.Text);

            if (nrKopjeve>0)
            {
                Huazimet huazimet = new Huazimet();
                huazimet.LibriID = int.Parse(lblLibriID1.Text.ToString());
                huazimet.KopjaID = int.Parse(txtKopjaID.Text);
                huazimet.PmID = int.Parse(lblPmID1.Text);
                huazimet.DataHuazimit = DataHuazimit1.Value;
                huazimet.AfatiKthimit = AfatiKthimit1.Value;
                huazimet.DataKthimit = null; 
                huazimet.Verejtje = string.Empty;
                huazimet.Huazim_Kthim = true;

                try
                {
                    
                    huazimet.HuazimiID = HuazimetBLL.ShtoHuazim(huazimet);

                    if (huazimet.HuazimiID==0)
                    {
                        MessageBox.Show("Nuk mund te merni me shume se nje liber ne te njejten kohe");
                    }
                    else
                    {
                        MessageBox.Show("Succesful Insert");
                        LibriBLL.SelectBooks(dgvBooks);

                        nrKopjeve--;
                        lblNumriKopjeve1.Text = lblNumriKopjeve1.Text;

                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unsuccesful Insert\n" + ex.Message);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Libri nuk gjendet ne biblotek momentalisht!");
            }
        }

        private void btnKthe_Click(object sender, EventArgs e)
        {

            Huazimet huazimet = new Huazimet();
            huazimet.LibriID = int.Parse(lblLibriID1.Text.ToString());
            huazimet.KopjaID = int.Parse(txtKopjaID.Text);
            huazimet.PmID = int.Parse(lblPmID1.Text);
            //huazimet.DataHuazimit = DataHuazimit1.Value;
            //huazimet.AfatiKthimit = AfatiKthimit1.Value;
            huazimet.DataKthimit = DataKthimit1.Value;
            huazimet.Verejtje = txtVerejtej.Text;
            huazimet.Huazim_Kthim = false;

            try
            {
              int index= HuazimetBLL.LargoHuazim(huazimet);
                if (index==1)
                {
                    MessageBox.Show("Libri u kthye");
                    LibriBLL.SelectBooks(dgvBooks);
                }
                else
                {
                    MessageBox.Show("Ju nuk e keni kete liber");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
