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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginBut_Click(object sender, EventArgs e)
        {
            if(loginFie.Text == "" || passFie.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            DataTable table = new DataTable();
            db.init().select("SELECT * FROM `users` WHERE BINARY `login` = @login AND BINARY `pass` = @pass;", new List<parami> { new parami("@login", loginFie.Text), new parami("@pass", passFie.Text) }, out table);
            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Неправильный логин или пароль!");
                return;
            }
            dbUsers.localuser = new dbUsers(table.Rows[0]);
            mainForm form = new mainForm();
            form.Show();
            this.Hide();
        }
    }
}
