using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banki
{
    public class db
    {
        private static db instance;

        MySqlConnection conn;



        public static db init()
        {
            if (instance == null)
                instance = new db();
            return instance;
        } 


        public db()
        {
            string connStr = "Server=localhos2t;User ID=luntiklaelite;password=123456789;database=banki;CharSet=utf8";
            conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка с соединением с базой данных!");
                return;
            }
        }

        private MySqlCommand genCommand(string comm, List<parami> list)
        {
            MySqlCommand command = new MySqlCommand(comm, getConnection());
            foreach(parami param in list)
            {
                command.Parameters.AddWithValue(param.paramname, param.paramvalue);
            }
            return command;
        }

        public bool exec(string sql, List<parami> list)
        {
            MySqlCommand command = genCommand(sql, list);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка с отправкой запроса к базе данных");
                return false;
            }
            return true;
        }

        public bool select(string sql, List<parami> list, out DataTable table)
        {
            MySqlCommand command = genCommand(sql, list);
            try
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    table = new DataTable();
                    try
                    {
                        table.Load(reader);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка с загрузкой данных в таблицу");
                        return false;
                    }
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка с загрузкой данных в таблицу!");
                table = null;
                return false;
            }
            
        }

        public MySqlConnection getConnection()
        {
            return conn;
        }
    }
}
