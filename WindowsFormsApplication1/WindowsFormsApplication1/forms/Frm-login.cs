using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.forms
{
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }
        contex2021Container con = new contex2021Container();

        private void btn_khoroj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        user u = new user();
        private void btn_vorod_Click(object sender, EventArgs e)
        {
            var q = con.users.Where(t => t.username == txt_usename.Text.Trim() && t.password == txt_ramz_obor.Text.Trim()).Select(y => y).ToList();
            if (q.Count > 0)
            {
                foreach (var x in q)
                {
                    u = x;
                }
                main frm_m = new main(u);
                frm_m.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("نام کاربری و رمز عبور نادرست است", "توجه");
                txt_usename.Clear();
                txt_ramz_obor.Clear();

            }
        }
    }
}
