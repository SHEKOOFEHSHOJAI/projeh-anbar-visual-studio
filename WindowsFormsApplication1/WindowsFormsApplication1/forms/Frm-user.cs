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
    public partial class Frm_user : Form
    {
        public Frm_user()
        {
            InitializeComponent();
        }
        // conction to table user
        contex2021Container con = new contex2021Container();
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)

        {
            if (txt_pass.Text.Trim() == txt_tekrar_pass.Text.Trim())
            { 
            //make object for class entity
            user us = new user();
            us.name = txt_name.Text.Trim();
            us.family = txt_namfamily.Text.Trim();
            us.level = cmb_sath_karbari.SelectedItem.ToString();
            us.username = txt_user_name.Text.Trim();
            us.password = txt_pass.Text.Trim();

            con.users.Add(us);
            con.SaveChanges();
            // clear value texbox
            txt_name.Clear();
            txt_namfamily.Clear();
            txt_user_name.Clear();
            txt_tekrar_pass.Clear();
            txt_pass.Clear();
                F_load();
        }
            else
            {
                MessageBox.Show("رمز عبور و تکرار ان باهم مطابقت ندارد", "توجه");
            }
         }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_pass.Text == txt_tekrar_pass.Text)
            { 
            user x = (user)data_grid_user.SelectedRows[0].DataBoundItem;
            x.name = txt_name.Text;
            x.family = txt_namfamily.Text;
            x.username = txt_user_name.Text;
            x.password = txt_pass.Text;
            x.level = cmb_sath_karbari.SelectedItem.ToString();
            con.SaveChanges();
            F_load();
                txt_name.Clear();
                txt_namfamily.Clear();
                txt_user_name.Clear();
                txt_tekrar_pass.Clear();
                txt_pass.Clear();
            }
            else
            {
                MessageBox.Show("رمز عبور و تکرار ان باهم مطابقت ندارد", "توجه",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }
        public void F_load()
        {
            var w = con.users.Select(p => p);
            data_grid_user.DataSource = w.ToList();
            data_grid_user.Columns[0].Visible = false;
            data_grid_user.Columns[1].HeaderText = "نام";
            data_grid_user.Columns[2].HeaderText = "نام خانوادگی";
            data_grid_user.Columns[3].HeaderText = "سطح کاربری";
            data_grid_user.Columns[4].HeaderText = "نام کاربری";
            data_grid_user.Columns[5].HeaderText = "رمز عبور";
            // for width data-grid column
            data_grid_user.Columns[1].Width =150;
            data_grid_user.Columns[2].Width = 150;
            data_grid_user.Columns[3].Width = 150;
            data_grid_user.Columns[4].Width = 150;
        }

        private void Frm_user_Load(object sender, EventArgs e)
        {
            F_load();
        }

        private void btn_delete_Click(object sender, EventArgs e)

        {

            int messagebox=(int) MessageBox.Show( "ایا مطمعا به حذف این ایتم هستید",
                "توجه",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);

            if (messagebox == 6)
            {
               user x =(user) data_grid_user.SelectedRows[0].DataBoundItem;
                con.users.Remove(x);
                con.SaveChanges();
                F_load();
            }




        }

        private void data_grid_user_Click(object sender, EventArgs e)
        {
            txt_name.Text = data_grid_user.SelectedRows[0].Cells[1].Value.ToString();
           txt_namfamily.Text = data_grid_user.SelectedRows[0].Cells[2].Value.ToString();
            cmb_sath_karbari.Text = data_grid_user.SelectedRows[0].Cells[3].Value.ToString();
            txt_user_name.Text = data_grid_user.SelectedRows[0].Cells[4].Value.ToString();

            txt_pass.Text = data_grid_user.SelectedRows[0].Cells[5].Value.ToString();
            txt_tekrar_pass.Text = data_grid_user.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
