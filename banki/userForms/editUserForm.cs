using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banki.userForms
{
    public partial class editUserForm : Form
    {
        dbUsers user;
        public editUserForm(dbUsers user)
        {
            InitializeComponent();
            combo_role.Items.Add("Администратор");
            combo_role.Items.Add("Пользователь");
            combo_role.Items.Add("Сотрудник банка");
            dateFie.Value = user.date;
            loginFie.Text = user.login;
            fioFie.Text = user.fio_user;
            combo_role.SelectedIndex = (int)user.role_user;
            this.user = user;
        }

        private void but_editUser_Click(object sender, EventArgs e)
        {
            string login, pass, fio;
            int role;
            login = loginFie.Text;
            pass = passFie.Text;
            fio = fioFie.Text;
            role = combo_role.SelectedIndex;
            
            if (combo_role.SelectedIndex <= -1)
                role = (int)user.role_user;
            if (loginFie.Text == "")
                login = user.login;
            if (passFie.Text == "")
                pass = user.pass;
            if (fioFie.Text == "")
                fio = user.fio_user;
            if(user.editUser(fio, login, pass, dateFie.Value, (dbUsers.roles)role))
            {
                MessageBox.Show("Успешно!");
                DialogResult = DialogResult.Yes;
                return;
            }
            DialogResult = DialogResult.No;
            return;
        }
    }
}
