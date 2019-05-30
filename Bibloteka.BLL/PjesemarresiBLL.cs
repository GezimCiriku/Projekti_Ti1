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
                AuthenticatedUser.Username = username;
                AuthenticatedUser.Role = RoliDal.GetRoleID(username, password);

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

        public static void SelectPm(DataGridView dg)
        {
            dg.DataSource = null;
            dg.DataSource = PjesemarresiDAL.GetPm();
        }
    }
}
