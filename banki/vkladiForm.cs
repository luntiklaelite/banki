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
            List<dbVkladi> list = dbVkladi.select();
            foreach(dbVkladi vkladi in list)
            {
                int r = dataGridView1.Rows.Add(vkladi.users.login, vkladi.vklHave.depName, vkladi.vkladSum, vkladi.date_vlozh.AddDays(vkladi.vklHave.depTime), vkladi.vkladSum + (vkladi.vklHave.depProc/100 * vkladi.vkladSum));
                dataGridView1.Rows[r].Tag = vkladi;
            }
        }
    }
}
