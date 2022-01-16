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
    }
}
