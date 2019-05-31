using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibloteka.BO;
using Bibloteka.DAL;

namespace Bibloteka.BLL
{
    public class PjesemarresiBLL
    {
        public static bool CheckLogin(string username, string password)
        {
            if (PjesemarresiDAL.ValidateLogin(username, password))
            {
                AuthenticateddUser.Username = username;
                AuthenticateddUser.Role = RoliDal.GetRoleID(username, password);
                AuthenticateddUser.PmID = PjesemarresiDAL.GetPmID(username, password);

                return true;
            }
            else
            {
                return false;
            }
        }

        public static int ShtoLexues(Pjesemarresit pm)
        {
            return PjesemarresiDAL.Insert(pm);
        }

        public static void SelectPm(DataGridView dg,int roliID)
        {
            dg.DataSource = null;
            dg.DataSource = PjesemarresiDAL.GetPm(roliID);
            dg.Columns[1].Visible = false;
        }

        public static bool Edit(Pjesemarresit pm)
        {
            return PjesemarresiDAL.UpdatePm(pm);

        }

        public static void SearchPm(DataGridView dg, string search,int roliID)
        {
            dg.DataSource = null;
            dg.DataSource = PjesemarresiDAL.SearchPm(search, roliID);
            dg.Columns[1].Visible = false;
        }

        public static bool Delete(int PmID)
        {
            return PjesemarresiDAL.DeletePm(PmID);
        }

        public static Pjesemarresit GetPm()
        {
            return PjesemarresiDAL.GetPmByID();
        }
    }
}
