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
    public partial class frm_kalaye_mayob : Form
    {
        public frm_kalaye_mayob()
        {
            InitializeComponent();
        }
        public int count_110 = 0;
        contex2021Container con = new contex2021Container();

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_tedad.Text) > count_110)
            {
                MessageBox.Show("تعدادبیشتر از موجودی انبار است", "توجه");
            }
            else
            {
                khalaye_mayoub ps = new khalaye_mayoub();
                ps.group = como_goroh_kala.Text.Trim();
                ps.name = como_name_kala.Text.Trim();
                ps.model= como_model_kala.Text.Trim();
                ps.count = txt_tedad.Text.Trim();
                ps.discription = txt_discription.Text.Trim();

                con.khalaye_mayoub.Add(ps);
                con.SaveChanges();
                f_load();
                //clear
                txt_discription.Clear();
             
                txt_tedad.Clear();
            }
        }
        private void frm_kalaye_mayob_Load(object sender, EventArgs e)
        {
            f_load();
        }

        public void f_load()
        {
            var q = con.khalaye_mayoub.Select(w => w);
            data_grid_mayob.DataSource = q.ToList();

            data_grid_mayob.Columns[0].Visible = false;
            data_grid_mayob.Columns[1].HeaderText = "گروه کالا";
            data_grid_mayob.Columns[2].HeaderText = "نام کالا";
            data_grid_mayob.Columns[3].HeaderText = "مدل کالا";
            data_grid_mayob.Columns[4].HeaderText = "تعداد";
            data_grid_mayob.Columns[5].HeaderText = "توضیحات";

            data_grid_mayob.Columns[1].Width = 100;
            data_grid_mayob.Columns[2].Width = 100;
            data_grid_mayob.Columns[3].Width = 100;
            data_grid_mayob.Columns[4].Width = 100;
            data_grid_mayob.Columns[5].Width = 275;

        }

        private void como_goroh_kala_SelectedIndexChanged(object sender, EventArgs e)
        {
            var q = con.vorods.Where(r => r.group == como_goroh_kala.SelectedItem).Select(p => p.name);
            como_name_kala.DataSource = q.ToList();
        }

        private void como_name_kala_SelectedIndexChanged(object sender, EventArgs e)
        {
            var q = con.vorods.Where(r => r.name == como_name_kala.SelectedItem).Select(p => p.model);
            como_model_kala.DataSource= q.ToList();
        }

        private void como_model_kala_SelectedIndexChanged(object sender, EventArgs e)
        {
            //وصل شو به پایگاه و چک کن اون مدلی ک انتخاب کردین با مدل پایگاه برابر است و اون ردیف رو برگردون
            var q = con.vorods.Where(y => y.model == como_model_kala.Text).Select(t => t).ToList();
            foreach (var x in q)
            {
                txt_tedad.Text = x.count.ToString();
                //string ra nmitavan into varable int rikht
                count_110 = Convert.ToInt32(x.count);
            }
        }

        private void data_grid_mayob_Click(object sender, EventArgs e)
        {
            como_goroh_kala.Text = data_grid_mayob.SelectedRows[0].Cells[1].Value.ToString();
            como_name_kala.Text = data_grid_mayob.SelectedRows[0].Cells[2].Value.ToString();
            como_model_kala.Text = data_grid_mayob.SelectedRows[0].Cells[3].Value.ToString();
           txt_tedad.Text = data_grid_mayob.SelectedRows[0].Cells[4].Value.ToString();
            txt_discription.Text = data_grid_mayob.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int messagebox = (int)MessageBox.Show("ایا مطمعا به حذف این ایتم هستید",
          "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (messagebox == 6)
            {
                khalaye_mayoub x = (khalaye_mayoub)data_grid_mayob.SelectedRows[0].DataBoundItem;
                con.khalaye_mayoub.Remove(x);
                con.SaveChanges();
                f_load();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            khalaye_mayoub x = (khalaye_mayoub)data_grid_mayob.SelectedRows[0].DataBoundItem;
           
            ///
            x.group = como_goroh_kala.Text;
            x.name = como_name_kala.Text;
            x.model = como_model_kala.Text;
            x.count = txt_tedad.Text;
            x.discription = txt_discription.Text;
            con.SaveChanges();
            f_load();
            /////
           
            txt_tedad.Clear();
            txt_discription.Clear();
        }

        private void data_grid_mayob_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
