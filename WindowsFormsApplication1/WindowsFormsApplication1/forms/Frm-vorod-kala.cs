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
    public partial class Frm_vorod_kala : Form
    {
        public Frm_vorod_kala()
        {
            InitializeComponent();
        }
        //conction to database

        contex2021Container con = new contex2021Container();
        private void btn_add_Click(object sender, EventArgs e)
        {
            vorod vo = new vorod();
            vo.name = txt_name_kala.Text;
            vo.group = como_goroh_kala.Text;
            vo.date = txt_tarikh.Text;
            vo.model = txt_model_kala.Text;
            vo.count = txt_tedad.Text;
            vo.tahvilgirandeh = como_tahvil_girandeh.Text;
            vo.tahvildahandeh = txt_tahvil_dahandeh.Text;
            vo.tell = txt_tell_tahvilgirandeh.Text;
            con.vorods.Add(vo);
            con.SaveChanges();
            f_load();
            //
            txt_name_kala.Clear();
            txt_tarikh.Clear();
            txt_model_kala.Clear();
            txt_tedad.Clear();
            txt_tell_tahvilgirandeh.Clear();
            txt_tahvil_dahandeh.Clear();
            txt_tell_tahvilgirandeh.Clear();

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_vorod_kala_Load(object sender, EventArgs e)
        {
            //about .... information in combobox
           var q = con.personels.Select(w => w.name+" "+w.family);
            como_tahvil_girandeh.DataSource = q.ToList();
            f_load();
        }

        public void f_load()
        {
            var q = con.vorods.Select(w => w);
            data_grid_vorod.DataSource = q.ToList();

            data_grid_vorod.Columns[0].Visible = false;
           data_grid_vorod.Columns[1].HeaderText = "تاریخ";
            data_grid_vorod.Columns[2].HeaderText = "گروه کالا";
            data_grid_vorod.Columns[3].HeaderText = "نام کالا";
            data_grid_vorod.Columns[4].HeaderText = "مدل کالا ";
            data_grid_vorod.Columns[5].HeaderText = "تعداد";
            data_grid_vorod.Columns[6].HeaderText = "تحویل گیرنده";
            data_grid_vorod.Columns[7].HeaderText = "تحویل دهنده";
            data_grid_vorod.Columns[8].HeaderText = "تماس";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            int messagebox = (int)MessageBox.Show("ایا مطمعا به حذف این ایتم هستید",
                "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (messagebox == 6)
            {
                vorod x = (vorod)data_grid_vorod.SelectedRows[0].DataBoundItem;
                con.vorods.Remove(x);
                con.SaveChanges();
               f_load();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            vorod x = (vorod)data_grid_vorod.SelectedRows[0].DataBoundItem;
            x.name = txt_name_kala.Text;
            x.date = txt_tarikh.Text;
            x.model =txt_model_kala.Text;
            x.count= txt_tedad.Text;
            x.tahvildahandeh = txt_tahvil_dahandeh.Text;
            x.tahvilgirandeh = txt_tell_tahvilgirandeh.Text;
            con.SaveChanges();
            f_load();
            txt_name_kala.Clear();
            txt_tarikh.Clear();
            txt_model_kala.Clear();
            txt_tedad.Clear();
            txt_tell_tahvilgirandeh.Clear();
            txt_tahvil_dahandeh.Clear();
           
        }

        private void data_grid_vorod_Click(object sender, EventArgs e)
        {
            txt_name_kala.Text = data_grid_vorod.SelectedRows[0].Cells[1].Value.ToString();
            txt_tarikh.Text = data_grid_vorod.SelectedRows[0].Cells[2].Value.ToString();

            txt_model_kala.Text = data_grid_vorod.SelectedRows[0].Cells[3].Value.ToString();
            txt_tedad.Text = data_grid_vorod.SelectedRows[0].Cells[4].Value.ToString();
            txt_tahvil_dahandeh.Text = data_grid_vorod.SelectedRows[0].Cells[5].Value.ToString();
            txt_tell_tahvilgirandeh.Text = data_grid_vorod.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
