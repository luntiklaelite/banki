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
    public partial class addVkladForm : Form
    {
        public addVkladForm()
        {
            InitializeComponent();
            combo_vkladi.Text = "";
            DataTable table = new DataTable();
            db.init().select("SELECT * FROM `vkladi_have`", new List<parami>(), out table);
            if (!error.checkTable(table))
                return;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                combo_vkladi.Items.Add(table.Rows[i]["depName"]);
            }

           /* foreach (DataRow row in table.Rows)
            {
                dbVklHave 
            }
            */
        }

        private void but_addVklad_Click(object sender, EventArgs e)
        {
            //int user_id = combo_vkladi.SelectedValue;
            //db.init().exec("INSERT INTO `vkladi` (`depId`, `userId`, `vklad_sum`) VALUES (@depId, @userId, @vklad_sum);", new List<parami> { new parami("@depId",combo_vkladi.SelectedValue), new parami("@userId",), new parami("@vklad_sum",summFie.Text) } );
        }
    }
}
