using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banki
{
    public class error
    {
        public static bool checkTable(DataTable table)
        {
            if(table == null)
            {
                MessageBox.Show("Ошибка с заполнением таблицы, либо она пришла пустой!");
                return false;
            }
            return true;
        }
    }
}
