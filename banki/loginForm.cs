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
            if (dbUsers.autorization(loginFie.Text, passFie.Text))
            {
                mainForm form = new mainForm();
                form.Show();
                this.Hide();
                return;
            }
        }
    }
}
