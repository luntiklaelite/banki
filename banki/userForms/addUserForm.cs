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
    public partial class addUserForm : Form
    {
        public addUserForm()
        {
            InitializeComponent();
            combo_role.Items.Add("Администратор");
            combo_role.Items.Add("Пользователь");
            combo_role.Items.Add("Сотрудник банка");
        }

        private void but_addUser_Click(object sender, EventArgs e)
        {
            if (loginFie.Text == "" || passFie.Text == "" || fioFie.Text == "" || combo_role.SelectedIndex <= -1)
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            if(dbUsers.addUser(fioFie.Text, loginFie.Text, passFie.Text, dateFie.Value, (dbUsers.roles)combo_role.SelectedIndex))
            {
                MessageBox.Show("Успешно!");
                this.DialogResult = DialogResult.Yes;
                this.Hide();
                return;
            }
            this.DialogResult = DialogResult.No;
            return;
        }
    }
}
