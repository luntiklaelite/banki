using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banki
{
    public class dbVkladi
    {
        public int vklad_id, depId, userId, vkladSum;
        public dbVkladi(DataRow row)
        {
            vklad_id = Convert.ToInt32(row["vklad_id"]);
            depId = Convert.ToInt32(row["depId"]);
            userId = Convert.ToInt32(row["userId"]);
            vkladSum = Convert.ToInt32(row["vkladSum"]);
        }
    }
}
