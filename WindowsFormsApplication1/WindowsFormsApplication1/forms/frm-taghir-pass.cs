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
    public partial class frm_taghir_pass : Form
    {
        public frm_taghir_pass()
        {
            InitializeComponent();
        }
        contex2021Container con = new contex2021Container();
        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        user d_t = new user();

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var q = con.users.Where(y => y.username == txt_user_name.Text.Trim() && y.password==txt__pass.Text).Select(w=>w).ToList();
            if (q.Count() > 0)
            {
               foreach(var x in q)
                {
                    d_t = x;
                }
                if (txt_pass_new.Text == txt_tekrar_pass_new.Text.Trim())
                {
                    d_t.password = txt_pass_new.Text.Trim();
                    con.SaveChanges();
                    MessageBox.Show("درخواست شما با موفقیت بروزرسانی شد", "توجه");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(" رمز عبور باتکرار رمز عبور تطابقت ندارد ", "توجه");
                    txt_pass_new.Clear();
                    txt_tekrar_pass_new.Clear();
                }
            }
            else
            {
                MessageBox.Show("نام کاربری یا رمز عبور وارده اشتباه است", "توجه");
            }
        }
    }
}
