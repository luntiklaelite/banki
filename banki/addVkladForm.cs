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
            table_users = new DataTable();

            List<dbVklHave> list = dbVklHave.select();
            foreach(dbVklHave vklHave in list)
            {
                if (vklHave.depActive == 0)
                    continue;
                combo_vkladi.Items.Add(vklHave);
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
            double summ;
            if(combo_vkladi.SelectedIndex <= -1 || combo_users.SelectedIndex <= -1 || summFie.Text == "" || !double.TryParse(summFie.Text, out summ))
                return;
            int vklad_id = Convert.ToInt32(((dbVklHave)combo_vkladi.SelectedItem).depositid);
            int user_id = Convert.ToInt32(table_users.Rows[combo_users.SelectedIndex]["id_user"]);
            if(db.init().exec("INSERT INTO `vkladi` (`depId`, `userId`, `vklad_sum`, `date_vlozh`) VALUES (@depId, @userId, @vklad_sum, @date);", new List<parami> { new parami("@depId",vklad_id), new parami("@userId",user_id), new parami("@vklad_sum",summ), new parami("@date",DateTime.Now.ToString("yyyy-MM-dd")) } ))
            {
                MessageBox.Show("Успешно!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ошибка с добавлением строки в базу данных!");
                return;
            }
        }
    }
}
