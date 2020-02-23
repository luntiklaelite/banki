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
    public partial class uprUserForm : Form
    {
        public uprUserForm()
        {
            InitializeComponent();
            List<dbUsers> list = dbUsers.select("");
            foreach (dbUsers users in list)
            {
                int r = gridUsers.Rows.Add(users.id_user, users.login, users.fio_user, users.date.ToLongDateString(), dbUsers.getRoleUser(users));
                gridUsers.Rows[r].Tag = users;
            }
        }

        private void but_delUser_Click(object sender, EventArgs e)
        {
            if (gridUsers.SelectedRows.Count < 1)
                return;

            if(((dbUsers)gridUsers.SelectedRows[0].Tag).role_user == (int)dbUsers.roles.admin)
            {
                MessageBox.Show("Невозможно удалить администратора!");
                return;
            }

            if (((dbUsers)gridUsers.SelectedRows[0].Tag).id_user == dbUsers.localuser.id_user)
            {
                MessageBox.Show("Невозможно удалить самого себя!");
                return;
            }

            var box = MessageBox.Show("Вы уверены, что хотите удалить этого пользователя ? ", "Удаление пользователя", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (box == DialogResult.No)
                return;
            else if(box == DialogResult.Yes)
            {
                DataTable table;
                int id_u = ((dbUsers)gridUsers.SelectedRows[0].Tag).id_user;
                if (db.init().select("SELECT * FROM  `users` ,  `vkladi` ,  `vkladi_have` WHERE  `vkladi`.`depId` =  `vkladi_have`.`depositid` AND  `vkladi`.`userId` =  `users`.`id_user` AND `vkladi`.`userId` = @id", new List<parami> { new parami("@id", id_u) }, out table))
                {
                    if (!error.checkTable(table))
                        return;
                    if (table.Rows.Count >= 1)
                    {
                        MessageBox.Show("Удаление невозможно! У пользователя есть записи о вкладах.");
                        return;
                    }
                    if(db.init().exec("DELETE FROM `users` WHERE `users`.`id_user` = @id;", new List<parami> { new parami("@id", id_u) }))
                    {
                        MessageBox.Show("Успешно!");
                        uprUserForm form = new uprUserForm();
                        form.Show();
                        this.Hide();
                        return;
                    }
                }
            }

        }

        private void but_addUser_Click(object sender, EventArgs e)
        {
            userForms.addUserForm form = new userForms.addUserForm();
            form.ShowDialog();
            if(form.DialogResult == DialogResult.Yes)
            {
                Hide();
                uprUserForm form1 = new uprUserForm();
                form1.Show();
            }
        }

        private void but_editUser_Click(object sender, EventArgs e)
        {
            if (gridUsers.SelectedRows.Count < 1)
                return;
            userForms.editUserForm form = new userForms.editUserForm((dbUsers)gridUsers.SelectedRows[0].Tag);
            form.ShowDialog();
            if(form.DialogResult == DialogResult.Yes)
            {
                Hide();
                uprUserForm form1 = new uprUserForm();
                form1.Show();
            }
        }

        private void but_poisk_Click(object sender, EventArgs e)
        {
            gridUsers.Rows.Clear();
            List<dbUsers> list = dbUsers.select(poiskFie.Text);
            foreach (dbUsers users in list)
            {
                int r = gridUsers.Rows.Add(users.id_user, users.login, users.fio_user, users.date.ToLongDateString(), dbUsers.getRoleUser(users));
                gridUsers.Rows[r].Tag = users;
            }
        }
    }
}
