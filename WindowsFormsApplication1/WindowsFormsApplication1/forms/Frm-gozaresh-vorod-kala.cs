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
    public partial class Frm_gozaresh_vorod_kala : Form
    {
        public Frm_gozaresh_vorod_kala()
        {
            InitializeComponent();
        }
        contex2021Container con = new contex2021Container();

        private  void txt_search_TextChanged(object sender, EventArgs e)
        {
            
            var q = con.vorods.Select(w => w);
            

            if (cmb_search.SelectedIndex== 0) //group
            {
              
                q = con.vorods.Where(z =>z.group==txt_search.Text).Select(u=>u);
               
            }
            else if (cmb_search.SelectedIndex== 1)//name
            {
                q = con.vorods.Where(z => z.name.StartsWith(txt_search.Text)).Select(u => u);
            }
            else if (cmb_search.SelectedIndex== 2){//model
                {

                    q = con.vorods.Where(z => z.model == txt_search.Text).Select(f => f);

                 }

                
            }
            data_gozaresh_vorod.DataSource = q.ToList();
        }
        public void f_load()
        {
            var q = con.vorods.Select(w => w);
            data_gozaresh_vorod.DataSource = q.ToList();

            data_gozaresh_vorod.Columns[0].Visible = false;
            data_gozaresh_vorod.Columns[1].HeaderText = "تاریخ";
            data_gozaresh_vorod.Columns[2].HeaderText = "گروه کالا";
            data_gozaresh_vorod.Columns[3].HeaderText = "نام کالا";
            data_gozaresh_vorod.Columns[4].HeaderText = "مدل کالا ";
            data_gozaresh_vorod.Columns[5].HeaderText = "تعداد";
            data_gozaresh_vorod.Columns[6].HeaderText = "تحویل گیرنده";
            data_gozaresh_vorod.Columns[7].HeaderText = "تحویل دهنده";
            data_gozaresh_vorod.Columns[8].HeaderText = "تماس";
        }

        private void Frm_gozaresh_vorod_kala_Load(object sender, EventArgs e)
        {
            f_load();
        }

        private void data_gozaresh_vorod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    } }
