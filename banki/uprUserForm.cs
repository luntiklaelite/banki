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
            var box = MessageBox.Show("Вы уверены, что хотите удалить этого пользователя ? ", "Удаление пользователя", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (box == DialogResult.No)
                return;

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
