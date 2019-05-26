using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.BO
{
    public class BaseObject
    {
        public BaseObject(int insertBy, DateTime insDate, int? updateBy, DateTime? updateDate, int updateNo)
        {
            InsertBy = insertBy;
            InsDate = insDate;
            UpdateBy = updateBy;
            UpdateDate = updateDate;
            UpdateNo = updateNo;
        }

        public int InsertBy { get; set; }
        public DateTime InsDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int UpdateNo { get; set; } = 0;


    }
}
