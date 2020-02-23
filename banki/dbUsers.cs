using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banki
{
    public class dbUsers
    {
        public int id_user;
        public string login, pass, fio_user;
        public roles role_user;
        public DateTime date;

        public static dbUsers localuser;

        public enum roles : int
        {
            admin = 0,
            user = 1,
            manager = 2
        }

        public dbUsers(DataRow row)
        {
            id_user = Convert.ToInt32(row["id_user"]);
            role_user = (roles)Convert.ToInt32(row["role"]);
            login = Convert.ToString(row["login"]);
            pass = Convert.ToString(row["pass"]);
            fio_user = Convert.ToString(row["fio"]);
            date = Convert.ToDateTime(row["datebirth"]);
        }


        public static bool selectUserById(int id, out DataTable table)
        {
            if (db.init().select("SELECT * FROM  `users` ,  `vkladi` ,  `vkladi_have` WHERE  `vkladi`.`depId` =  `vkladi_have`.`depositid` AND  `vkladi`.`userId` =  `users`.`id_user` AND `vkladi`.`userId` = @id", new List<parami> { new parami("@id", id) }, out table))
                return true;
            return false;
        }

        public static bool addUser(string fio, string login, string pass, DateTime datebirth, roles role)
        {
            if (db.init().exec("INSERT INTO `users` (`fio`, `login`, `pass`, `datebirth`, `role`) VALUES ( @fio, @login, @pass, @date, @role);", new List<parami> { new parami("@fio", fio), new parami("@login", login), new parami("@pass", pass), new parami("@date", datebirth.ToString("yyyy-MM-dd")), new parami("@role", role) }))
                return true;
            return false;
        }

        public bool editUser(string fio, string login, string pass, DateTime datebirth, roles role)
        {
            if (db.init().exec("UPDATE `users` SET `fio` = @fio, `login` = @login, `pass` = @pass, `datebirth` = @date, `role` =  @role WHERE `users`.`id_user` = @id_user;", new List<parami> { new parami("@fio", fio), new parami("@login", login), new parami("@pass", pass), new parami("@date", datebirth.ToString("yyyy-MM-dd")), new parami("@role", role), new parami("@id_user", id_user) }))
                return true;
            return false;
        }
        public bool deleteUser()
        {
            if (db.init().exec("DELETE FROM `users` WHERE `users`.`id_user` = @id;", new List<parami> { new parami("@id", id_user) }))
                return true;
            return false;
        }

        public static bool autorization(string login, string pass)
        {
            DataTable table = new DataTable();
            db.init().select("SELECT * FROM `users` WHERE BINARY `login` = @login AND BINARY `pass` = @pass;", new List<parami> { new parami("@login", login), new parami("@pass", pass) }, out table);
            if (!error.checkTable(table))
                return false;
            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Неправильный логин или пароль!");
                return false;
            }
            localuser = new dbUsers(table.Rows[0]);
            return true;
        }

        public static string getRoleUser(dbUsers user1)
        {
            if (user1.role_user == roles.admin)
                return "Администратор";
            if (user1.role_user == roles.user)
                return "Пользователь";
            if (user1.role_user == roles.manager)
                return "Сотрудник банка";
            return "Неизвестная";
        }

        public override string ToString()
        {
            return login;
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
