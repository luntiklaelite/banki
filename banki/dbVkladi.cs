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
        public dbVklHave vklHave;
        public dbUsers users;

        public int vklad_id, depId, userId;
        public double vkladSum;
        public DateTime date_vlozh;

        public dbVkladi(DataRow row)
        {
            vklad_id = Convert.ToInt32(row["vklad_id"]);
            depId = Convert.ToInt32(row["depId"]);
            userId = Convert.ToInt32(row["userId"]);
            vkladSum = Convert.ToDouble(row["vklad_sum"]);
            date_vlozh = Convert.ToDateTime(row["date_vlozh"]);
        }

        public static List<dbVkladi> select(string filter)
        {
            DataTable table = new DataTable();
            if (dbUsers.localuser.role_user == (int)dbUsers.roles.admin)
            {
                if(filter == "")
                    db.init().select("SELECT * FROM  `users` ,  `vkladi` ,  `vkladi_have` WHERE  `vkladi`.`depId` =  `vkladi_have`.`depositid` AND  `vkladi`.`userId` =  `users`.`id_user`", new List<parami> { }, out table);
                else
                {
                    db.init().select("SELECT * FROM  `users` ,  `vkladi` ,  `vkladi_have` WHERE  `vkladi`.`depId` =  `vkladi_have`.`depositid` AND  `vkladi`.`userId` =  `users`.`id_user` AND `login` LIKE @filter", new List<parami> { new parami("@filter", "%" + filter + "%") }, out table);
                }
            }
            else if (dbUsers.localuser.role_user == (int)dbUsers.roles.user)
            {
                db.init().select("SELECT * FROM  `users` ,  `vkladi` ,  `vkladi_have` WHERE  `vkladi`.`depId` =  `vkladi_have`.`depositid` AND  `vkladi`.`userId` =  `users`.`id_user` AND `vkladi`.`userId` = @id", new List<parami> { new parami("@id", dbUsers.localuser.id_user) }, out table);
            }
            if (!error.checkTable(table))
                return null;
            List<dbVkladi> list = new List<dbVkladi>();
            foreach(DataRow row in table.Rows)
            {
                dbVkladi vkladi = new dbVkladi(row);
                vkladi.users = new dbUsers(row);
                vkladi.vklHave = new dbVklHave(row);
                list.Add(vkladi);
            }
            return list;
        }
    }
}
