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
            if(db.init().exec("UPDATE `users` SET `fio` = @fio, `login` = @login, `pass` = @pass, `datebirth` = @date, `role` =  @role WHERE `users`.`id_user` = @id_user;", new List<parami> { new parami("@fio",fio), new parami("@login",login), new parami("@pass",pass), new parami("@date", Convert.ToDateTime(dateFie.Text).ToString("yyyy-MM-dd")), new parami("@role",role), new parami("@id_user", user.id_user), }))
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
