using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banki
{
    public partial class addVkladForm : Form
    {
        DataTable table_vkladi, table_users;
        public addVkladForm()
        {
            InitializeComponent();
            table_vkladi = new DataTable();


            db.init().select("SELECT * FROM `vkladi_have`", new List<parami>(), out table_vkladi);
            if (!error.checkTable(table_vkladi))
                return;
            for (int i = 0; i < table_vkladi.Rows.Count; i++)
            {
                if (Convert.ToInt32(table_vkladi.Rows[i]["depActive"]) == 0)
                {
                  //  table_vkladi.Rows[i].
                    table_vkladi.Rows[i].Delete();
                    continue;
                }
                combo_vkladi.Items.Add(table_vkladi.Rows[i]["depName"]);
            }

            db.init().select("SELECT * FROM `users`", new List<parami>(), out table_users);
            if (!error.checkTable(table_users))
                return;
            for (int i = 0; i < table_users.Rows.Count; i++)
            {
                combo_users.Items.Add(table_users.Rows[i]["login"]);
            }
        }

        private void but_addVklad_Click(object sender, EventArgs e)
        {
            int vklad_id = Convert.ToInt32(table_vkladi.Rows[combo_vkladi.SelectedIndex]["depositid"]);
            int user_id = Convert.ToInt32(table_users.Rows[combo_users.SelectedIndex]["id_user"]);
            db.init().exec("INSERT INTO `vkladi` (`depId`, `userId`, `vklad_sum`) VALUES (@depId, @userId, @vklad_sum);", new List<parami> { new parami("@depId",vklad_id), new parami("@userId",user_id), new parami("@vklad_sum",summFie.Text) } );
        }
    }
}
