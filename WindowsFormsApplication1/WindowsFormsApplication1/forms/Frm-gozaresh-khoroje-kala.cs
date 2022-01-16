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
    public partial class Frm_gozaresh_khoroje_kala : Form
    {
        public Frm_gozaresh_khoroje_kala()
        {
            InitializeComponent();
        }
        contex2021Container con = new contex2021Container();

        private void data_grid_personel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            var q = con.khorojes.Select(w => w);


            if (com_search.SelectedIndex == 0) //group
            {

                q = con.khorojes.Where(z => z.group == txt_search.Text).Select(u => u);

            }
            else if (com_search.SelectedIndex == 1)//name
            {
                q = con.khorojes.Where(z => z.name.StartsWith(txt_search.Text)).Select(u => u);
            }
            else if (com_search.SelectedIndex == 2)
            {//model


                q = con.khorojes.Where(z => z.model == txt_search.Text).Select(f => f);




            }
            data_grid_gozaresh_khoroj.DataSource = q.ToList();
        }



        public void f_load()
        {
            var q = con.khorojes.Select(t => t);
            data_grid_gozaresh_khoroj.DataSource = q.ToList();

            data_grid_gozaresh_khoroj.Columns[0].Visible = false;
            data_grid_gozaresh_khoroj.Columns[1].HeaderText = "تاریخ";
            data_grid_gozaresh_khoroj.Columns[2].HeaderText = "نام کالا";

            data_grid_gozaresh_khoroj.Columns[3].HeaderText = "مدل کالا";
            data_grid_gozaresh_khoroj.Columns[4].HeaderText = " تعداد";
            data_grid_gozaresh_khoroj.Columns[5].HeaderText = "تحویل دهنده";

            data_grid_gozaresh_khoroj.Columns[6].HeaderText = "تحویل گیرنده";
            data_grid_gozaresh_khoroj.Columns[7].HeaderText = "گروه کالا";



            data_grid_gozaresh_khoroj.Columns[8].HeaderText = "تماس";
            data_grid_gozaresh_khoroj.Columns[9].HeaderText = "ادرس";






        }

        private void Frm_gozaresh_khoroje_kala_Load(object sender, EventArgs e)
        {
            f_load();
        }
    }
}
