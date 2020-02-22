using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banki
{
    public class dbUsers
    {
        public int id_user, role_user;
        public string login, pass, fio_user;
        public DateTime date;

        public static dbUsers localuser;

        public enum roles : int
        {
            admin = 0,
            user = 1,
            manager = 2
        }

        public static string getRoleUser(dbUsers user1)
        {
            if (user1.role_user == (int)roles.admin)
                return "Администратор";
            if (user1.role_user == (int)roles.user)
                return "Пользователь";
            if (user1.role_user == (int)roles.manager)
                return "Сотрудник банка";
            return "Неизвестная";
        }
        
        public dbUsers(DataRow row)
        {
            id_user = Convert.ToInt32(row["id_user"]);
            role_user = Convert.ToInt32(row["role"]);
            login = Convert.ToString(row["login"]);
            pass = Convert.ToString(row["pass"]);
            fio_user = Convert.ToString(row["fio"]);
            date = Convert.ToDateTime(row["datebirth"]);
        }

        public static List<dbUsers> select(string filter)
        {
            List<dbUsers> list = new List<dbUsers>();
            DataTable table = new DataTable();
            if (filter == "")
            {
                if (db.init().select("SELECT * FROM `users`", new List<parami>(), out table))
                {
                    if (!error.checkTable(table))
                        return null;
                    foreach (DataRow row in table.Rows)
                    {
                        list.Add(new dbUsers(row));
                    }
                    return list;
                }
            }
            else
            {
                if (db.init().select("SELECT * FROM `users` WHERE `login` LIKE @filter OR `fio` LIKE @filter", new List<parami> { new parami("@filter", "%" + filter + "%") }, out table))
                {
                    if (!error.checkTable(table))
                        return null;
                    foreach (DataRow row in table.Rows)
                    {
                        list.Add(new dbUsers(row));
                    }
                    return list;
                }
            }
            return null;
        }
    }
}
