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
    public partial class frm_gozaresh_kalaye_mayob : Form
    {
        public frm_gozaresh_kalaye_mayob()
        {
            InitializeComponent();
        }
        contex2021Container con = new contex2021Container();

        private void txt_model_kala_TextChanged(object sender, EventArgs e)
        {
                    }



      

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            var q = con.khalaye_mayoub.Select(w => w);


            if (cmb_search.SelectedIndex == 0) //group
            {

                q = con.khalaye_mayoub.Where(z => z.group == txt_search.Text).Select(u => u);

            }
            else if (cmb_search.SelectedIndex == 1)//name
            {
                q = con.khalaye_mayoub.Where(z => z.name.StartsWith(txt_search.Text)).Select(u => u);
            }
            else if (cmb_search.SelectedIndex == 2)
            {//model
               

                    q = con.khalaye_mayoub.Where(z => z.model == txt_search.Text).Select(f => f);

                


            }
            data_grid_gozaresh_mayob.DataSource = q.ToList();
        }


        public void f_load()
        {
            var q = con.khalaye_mayoub.Select(w => w);
            data_grid_gozaresh_mayob.DataSource = q.ToList();

            data_grid_gozaresh_mayob.Columns[0].Visible = false;
            data_grid_gozaresh_mayob.Columns[1].HeaderText = "تاریخ";
            data_grid_gozaresh_mayob.Columns[2].HeaderText = "گروه کالا";
            data_grid_gozaresh_mayob.Columns[3].HeaderText = "نام کالا";
            data_grid_gozaresh_mayob.Columns[4].HeaderText = "مدل کالا ";
            //////
            data_grid_gozaresh_mayob.Columns[1].Width = 100;
            data_grid_gozaresh_mayob.Columns[2].Width = 100;
            data_grid_gozaresh_mayob.Columns[3].Width = 100;
            data_grid_gozaresh_mayob.Columns[4].Width = 100;
            data_grid_gozaresh_mayob.Columns[5].Width = 275;

        }

        private void frm_gozaresh_kalaye_mayob_Load(object sender, EventArgs e)
        {
            f_load();
        }

        private void data_grid_gozaresh_mayob_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void data_grid_gozaresh_mayob_Click(object sender, EventArgs e)
        {
          
        }
    }
}
