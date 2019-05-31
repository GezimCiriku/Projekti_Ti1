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
    public partial class MyProfile : Form
    {
        public MyProfile()
        {
            InitializeComponent();
        }

        private void MyProfile_Load(object sender, EventArgs e)
        {
            Pjesemarresit pm = new Pjesemarresit();

            pm = PjesemarresiBLL.GetPm();

            lblID.Text = AuthenticateddUser.PmID.ToString();
            lblEmri.Text = pm.Emri;
            lblMbiemri.Text = pm.Mbiemri;
            lblNrTel.Text = pm.NrTel;
            lblEmail.Text = pm.Email;
            lblNofka.Text = pm.Username;
            lblFjalekalimi.Text = pm.Password;
        }
    }
}
