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
    public partial class Frm_personel : Form
    {
        public Frm_personel()
        {
            InitializeComponent();
        }
        contex2021Container con = new contex2021Container();

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            personel ps= new personel();
            ps.name = txt_name.Text;
            ps.family = txt_namfamily.Text;
          
            ps.codemeli = txt_code_meli.Text;
           
            ps.phonenumber = txt_tell.Text;
            ps.job = txt_job.Text;
            ps.adress = txt_adress.Text;
          
          
            con.personels.Add(ps);
            con.SaveChanges();
            ///////
            txt_name.Clear();
            txt_namfamily.Clear();
            txt_adress.Clear();
            txt_code_meli.Clear();
            txt_job.Clear();
            txt_tell.Clear();
            f_load();
            
        }
        public void f_load()
        {
            var q = con.personels.Select(w => w);
            data_grid_personel.DataSource = q.ToList();
            data_grid_personel.Columns[0].Visible = false;
            data_grid_personel.Columns[1].HeaderText = "نام";
            data_grid_personel.Columns[2].HeaderText = "نام خانوادگی";
            data_grid_personel.Columns[3].HeaderText = "کد ملی";
            data_grid_personel.Columns[4].HeaderText = "شماره تلفن";
            data_grid_personel.Columns[5].HeaderText = "شغل";
            data_grid_personel.Columns[6].HeaderText = "ادرس";
           
           
        }

        private void Frm_personel_Load(object sender, EventArgs e)
        {
            f_load();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int messagebox = (int)MessageBox.Show("ایا مطمعا به حذف این ایتم هستید",
               "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (messagebox == 6)
            {
                personel x = (personel)data_grid_personel.SelectedRows[0].DataBoundItem;
                con.personels.Remove(x);
                con.SaveChanges();
                f_load();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            personel x = (personel)data_grid_personel.SelectedRows[0].DataBoundItem;
            x.name = txt_name.Text;
            x.family = txt_namfamily.Text;
            x.codemeli = txt_code_meli.Text;
            x.phonenumber =txt_tell.Text;
            x.job = txt_job.Text;
            x.adress = txt_adress.Text;

            con.SaveChanges();
            f_load();
            txt_name.Clear();
            txt_namfamily.Clear();
           
        }

        private void data_grid_personel_Click(object sender, EventArgs e)
        {
            txt_name.Text = data_grid_personel.SelectedRows[0].Cells[1].Value.ToString();
            txt_namfamily.Text = data_grid_personel.SelectedRows[0].Cells[2].Value.ToString();
            txt_code_meli.Text = data_grid_personel.SelectedRows[0].Cells[3].Value.ToString();
           txt_tell.Text = data_grid_personel.SelectedRows[0].Cells[4].Value.ToString();
            txt_job.Text = data_grid_personel.SelectedRows[0].Cells[5].Value.ToString();
           txt_adress.Text = data_grid_personel.SelectedRows[0].Cells[6].Value.ToString();
        }
    }
}
