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

    }
}
