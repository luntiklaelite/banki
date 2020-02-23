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

        public int vklad_id, depId, userId, vidan;
        public double vkladSum;
        public DateTime date_vlozh;

        public dbVkladi(DataRow row)
        {
            vklad_id = Convert.ToInt32(row["vklad_id"]);
            depId = Convert.ToInt32(row["depId"]);
            userId = Convert.ToInt32(row["userId"]);
            vkladSum = Convert.ToDouble(row["vklad_sum"]);
            date_vlozh = Convert.ToDateTime(row["date_vlozh"]);
            vidan = Convert.ToInt32(row["vidan"]);
        }

        public static bool addVklad(int vkl_id, int user_id, double summ)
        {
            if (db.init().exec("INSERT INTO `vkladi` (`depId`, `userId`, `vklad_sum`, `date_vlozh`) VALUES (@depId, @userId, @vklad_sum, @date);", new List<parami> { new parami("@depId", vkl_id), new parami("@userId", user_id), new parami("@vklad_sum", summ), new parami("@date", DateTime.Now.ToString("yyyy-MM-dd")) }))
                return true;
            return false;
        }
        
        public bool setVkladVidan()
        {
            if (db.init().exec("UPDATE  `vkladi` SET  `vidan` =  '1' WHERE  `vkladi`.`vklad_id` = @vklad_id;", new List<parami> { new parami("@vklad_id", vklad_id) }))
                return true;
            return false;
        }

        public static List<dbVkladi> select(string filter)
        {
            DataTable table = new DataTable();
            if (dbUsers.localuser.role_user == dbUsers.roles.admin)
            {
                if(filter == "")
                    db.init().select("SELECT * FROM  `users` ,  `vkladi` ,  `vkladi_have` WHERE  `vkladi`.`depId` =  `vkladi_have`.`depositid` AND  `vkladi`.`userId` =  `users`.`id_user`", new List<parami> { }, out table);
                else
                {
                    db.init().select("SELECT * FROM  `users` ,  `vkladi` ,  `vkladi_have` WHERE  `vkladi`.`depId` =  `vkladi_have`.`depositid` AND  `vkladi`.`userId` =  `users`.`id_user` AND `login` LIKE @filter", new List<parami> { new parami("@filter", "%" + filter + "%") }, out table);
                }
            }
            else if (dbUsers.localuser.role_user == dbUsers.roles.user)
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
