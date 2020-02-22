using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banki
{
    public class dbVklHave
    {
        public int depositid, depTime, depActive;
        public double depProc;
        public string depName, depDescr;
        public dbVklHave(DataRow row)
        {
            depositid = Convert.ToInt32(row["depositid"]);
            depTime  = Convert.ToInt32(row["depTime"]);
            depActive = Convert.ToInt32(row["depActive"]);
            depProc = Convert.ToDouble(row["depProc"]);
            depName = Convert.ToString(row["depName"]);
            depDescr = Convert.ToString(row["depDescr"]);
        }

        public override string ToString()
        {
            return Convert.ToString(depositid);

        }

        public static List<dbVklHave> select()
        {
            List<dbVklHave> list = new List<dbVklHave>();
            DataTable table = new DataTable();

            db.init().select("SELECT * FROM `vkladi_have`", new List<parami>(), out table);
            if (!error.checkTable(table))
                return null;
            foreach(DataRow row in table.Rows)
            {
                list.Add(new dbVklHave(row));
            }
            return list;
        }

    }
}
