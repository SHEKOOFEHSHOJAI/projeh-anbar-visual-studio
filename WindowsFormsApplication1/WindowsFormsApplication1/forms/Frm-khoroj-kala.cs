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
    public partial class Frm_khoroj_kala : Form
    {
        public Frm_khoroj_kala()
        {
            InitializeComponent();
        }
        //سزاسری 
        public int count_110 = 0;
        contex2021Container con = new contex2021Container();

        private void data_grid_personel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
            
        {
            if (Convert.ToInt32(txt_tedad.Text)>count_110 )
            {
                MessageBox.Show("تعدادبیشتر از موجودی انبار است", "توجه");
            }
            else { 
            khoroje ps = new khoroje();
            ps.date = txt_tarikh.Text.Trim();
                ps.group = como_goroh_kala.Text.Trim();
                ps.name = como_name_kala.Text.Trim();
            ps.model = com_model_kala.Text.Trim();
            ps.count = txt_tedad.Text.Trim();
            ps.tahvildahandeh = como_tahvil_dahandeh.Text.Trim();
            ps.tahvilgirandeh = txt_tahvil_girandeh.Text.Trim();
           
            ps.tell = txt_tell.Text.Trim();
            ps.adress = txt_adress_tahvil_girandeh.Text.Trim();
           
          
            con.khorojes.Add(ps);
            con.SaveChanges();
            f_load();
            }
            /////
            txt_tarikh.Clear();
            txt_tedad.Clear();
            txt_tahvil_girandeh.Clear();
        }
        public void f_load (){
            var q = con.khorojes.Select(t => t);
            data_grid_khoroj.DataSource = q.ToList();
           
            data_grid_khoroj.Columns[0].Visible = false;
            data_grid_khoroj.Columns[1].HeaderText = "تاریخ";
            data_grid_khoroj.Columns[2].HeaderText = "گروه کالا";
            data_grid_khoroj.Columns[3].HeaderText = "نام کالا";
            data_grid_khoroj.Columns[4].HeaderText = "مدل کالا";
            data_grid_khoroj.Columns[5].HeaderText = " تعداد";
            data_grid_khoroj.Columns[6].HeaderText = "تحویل دهنده";

            data_grid_khoroj.Columns[7].HeaderText = "تحویل گیرنده";
            
           
          
            data_grid_khoroj.Columns[8].HeaderText = "تماس";
            data_grid_khoroj.Columns[9].HeaderText = "ادرس";



    


        }
        private void como_goroh_kala_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ریختن اطلاعات گروه کالا در دیتابیس ورود گروه کالا در نام کالا 
            var q = con.vorods.Where(r=>r.group==como_goroh_kala.SelectedItem).Select(p => p.name);
            como_name_kala.DataSource = q.ToList();

        }

        private void como_name_kala_SelectedIndexChanged(object sender, EventArgs e)
        {
            var q = con.vorods.Where(r => r.name == como_name_kala.SelectedItem).Select(p => p.model);
            com_model_kala.DataSource = q.ToList();

        }

        private void Frm_khoroj_kala_Load(object sender, EventArgs e)
        {
            var q = con.personels.Select(y => y.name + " " + y.family);
            como_tahvil_dahandeh.DataSource = q.ToList();
            f_load();
        }

        private void data_grid_khoroj_Click(object sender, EventArgs e)
        {

            txt_tarikh.Text = data_grid_khoroj.SelectedRows[0].Cells[1].Value.ToString();
            como_goroh_kala.Text = data_grid_khoroj.SelectedRows[0].Cells[7].Value.ToString();
            como_name_kala.Text =data_grid_khoroj.SelectedRows[0].Cells[2].Value.ToString();
            com_model_kala.Text = data_grid_khoroj.SelectedRows[0].Cells[3].Value.ToString();
            txt_tedad.Text = data_grid_khoroj.SelectedRows[0].Cells[4].Value.ToString();
            como_tahvil_dahandeh.Text = data_grid_khoroj.SelectedRows[0].Cells[5].Value.ToString();
            txt_tahvil_girandeh.Text = data_grid_khoroj.SelectedRows[0].Cells[6].Value.ToString();
          
            txt_tell.Text= data_grid_khoroj.SelectedRows[0].Cells[8].Value.ToString();
            txt_adress_tahvil_girandeh.Text= data_grid_khoroj.SelectedRows[0].Cells[9].Value.ToString();

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            khoroje x = (khoroje)data_grid_khoroj.SelectedRows[0].DataBoundItem;
            x.date = txt_tarikh.Text;
            x.name = como_name_kala.Text;
           x.model = com_model_kala.Text;
           x.count = txt_tedad.Text;
            x.tahvildahandeh = como_tahvil_dahandeh.Text;
            x.tahvilgirandeh = txt_tahvil_girandeh.Text;
            x.group = como_goroh_kala.Text;
            x.tell = txt_tell.Text;
            x.adress = txt_adress_tahvil_girandeh.Text;

           
            con.SaveChanges();
            f_load();
            /////
            txt_tarikh.Clear();
            txt_tedad.Clear();
            txt_tahvil_girandeh.Clear();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int messagebox = (int)MessageBox.Show("ایا مطمعا به حذف این ایتم هستید",
            "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (messagebox == 6)
            {
                khoroje x = (khoroje)data_grid_khoroj.SelectedRows[0].DataBoundItem;
                con.khorojes.Remove(x);
                con.SaveChanges();
                f_load();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void com_model_kala_SelectedIndexChanged(object sender, EventArgs e)
        {
            //وصل شو به پایگاه و چک کن اون مدلی ک انتخاب کردین با مدل پایگاه برابر است و اون ردیف رو برگردون
            var q = con.vorods.Where(y => y.model == com_model_kala.Text).Select(t => t).ToList();
            foreach(var x in q)
            {
               txt_tedad.Text = x.count.ToString();
                //string ra nmitavan into varable int rikht
                count_110 = Convert.ToInt32(x.count);
            }
           
        }
    }
}
