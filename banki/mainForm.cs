﻿using System;
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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            privetLabel.Text = "Здравствуйте,\n" + dbUsers.localuser.fio_user + "\nВаша роль в системе: " + dbUsers.getlocaluserRole();
            if(dbUsers.localuser.role_user == (int)dbUsers.roles.manager)
            {
                but_vkladi.Visible = false;
                but_addVklad.Location = but_vkladi.Location;
            }
            else if(dbUsers.localuser.role_user == (int)dbUsers.roles.admin)
            {
            }
            else if(dbUsers.localuser.role_user == (int)dbUsers.roles.user)
            {
                but_addVklad.Visible = false;
            }
            else
            {
                but_vkladi.Visible = false;
                but_addVklad.Visible = false;
            }


        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void but_addVklad_Click(object sender, EventArgs e)
        {
            addVkladForm form = new addVkladForm();
            form.Show();
        }
    }
}
