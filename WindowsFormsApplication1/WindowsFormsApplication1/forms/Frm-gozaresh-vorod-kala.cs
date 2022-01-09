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
            
            var q = con.vorods.Select(z => z);
            

            if (cmb_search.SelectedIndex == 0) //group
            {
              
                q = con.vorods.Where(z =>z.group==txt_search.Text).Select(u=>u);
               
            }
            else if (cmb_search.SelectedIndex == 1)//name
            {
                q = con.vorods.Where(z => z.group == txt_search.Text).Select(u => u);
            }
            else if (cmb_search.SelectedIndex == 2){//model
                {

                    q = con.vorods.Where(z => z.group == txt_search.Text);

                 }

            }
        }} }
