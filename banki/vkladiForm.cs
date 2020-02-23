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
    public partial class vkladiForm : Form
    {
        public vkladiForm()
        {
            InitializeComponent();
            reloadGrid();
            if(dbUsers.localuser.role_user != (int)dbUsers.roles.admin)
            {
                poiskFie.Visible = false;
                but_poisk.Visible = false;
            }
        }


        private void reloadGrid()
        {
            grid_vkladi.Rows.Clear();
            List<dbVkladi> list = dbVkladi.select("");
            foreach (dbVkladi vkladi in list)
            {
                int r = grid_vkladi.Rows.Add(vkladi.users.login, vkladi.vklHave.depName, vkladi.vkladSum, vkladi.date_vlozh.AddDays(vkladi.vklHave.depTime).ToLongDateString(), vkladi.vkladSum + (vkladi.vklHave.depProc / 100 * vkladi.vkladSum));
                grid_vkladi.Rows[r].Tag = vkladi;
                if (vkladi.vidan == 1)
                    grid_vkladi.Rows[r].DefaultCellStyle.BackColor = Color.FromArgb( 0, 233, 100);
            }
        }

        private void but_infoUser_Click(object sender, EventArgs e)
        {
            if(grid_vkladi.SelectedRows.Count < 1)
            {
                MessageBox.Show("Выберите строчку!");
                return;
            }
            dbVkladi vkladi = (dbVkladi)grid_vkladi.SelectedRows[0].Tag;
            MessageBox.Show("ID пользователя:\t" + vkladi.users.id_user + "\nЛогин:\t\t" + vkladi.users.login + "\nФИО:\t\t" + vkladi.users.fio_user + "\nДата рождения:\t" + vkladi.users.date.ToLongDateString() + "\nРоль в системе:\t" + dbUsers.getRoleUser(vkladi.users));
        }

        private void but_infoDep_Click(object sender, EventArgs e)
        {
            if (grid_vkladi.SelectedRows.Count < 1)
            {
                MessageBox.Show("Выберите строчку!");
                return;
            }
            dbVkladi vkladi = (dbVkladi)grid_vkladi.SelectedRows[0].Tag;
            MessageBox.Show("ID депозита в системе:\t" + vkladi.vklHave.depositid + "\nНазвание:\t\t" + vkladi.vklHave.depName + "\nПроцентная ставка:\t" + vkladi.vklHave.depProc + "\nНа сколько дней:\t\t" + vkladi.vklHave.depTime + "\nОписание депозита:\n\n" + vkladi.vklHave.depDescr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reloadGrid();
        }

        private void but_vidan_Click(object sender, EventArgs e)
        {


            if (grid_vkladi.SelectedRows.Count < 1)
            {
                MessageBox.Show("Выберите строчку!");
                return;
            }
            dbVkladi vkladi = (dbVkladi)grid_vkladi.SelectedRows[0].Tag;
            if (vkladi.date_vlozh.AddDays(vkladi.vklHave.depTime) > DateTime.UtcNow)
            {
                MessageBox.Show("Нельзя пометить вклад выданым, если его срок ещё не кончился!");
                return;
            }


            if(vkladi.setVkladVidan())
            {
                MessageBox.Show("Вы пометили, что вклад выдан!");
                reloadGrid();
                return;
            }
            MessageBox.Show("Ошибка с обновлением строки в базе данных!");
            return;
        }
    }
}
