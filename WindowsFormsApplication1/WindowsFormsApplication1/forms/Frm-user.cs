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
            if (txt_tekrar_pass == txt_tekrar_pass)
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
        }
         }
        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
