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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        user ob_u = new user();
        public main(user st)
        {
            InitializeComponent();
            ob_u = st;
        }

        private void main_Load(object sender, EventArgs e)

        {
            //دسترسی به نیم و فامیلی جدول یوذر
            lbl_name_family.Text = ob_u.name + " " + ob_u.family;
            
            lbl_l.Text = "           "+ob_u.level+"         ";
        }

        private void دستورالعملاستفادهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_dastorolamal obj_dastorolamal = new Frm_dastorolamal();
            obj_dastorolamal.ShowDialog();

        }

        private void m_tarif_karbar_Click(object sender, EventArgs e)
        {
            Frm_user object_user = new Frm_user();//تعریف شی از فرم یوذر
            object_user.ShowDialog();

        }

        private void m_tarif_personel_Click(object sender, EventArgs e)
        {
            Frm_personel object_personel = new Frm_personel();
            object_personel.ShowDialog();

        }

        private void m_taghir_ramz_obor_Click(object sender, EventArgs e)
        {
            frm_taghir_pass object_taghir_pass = new frm_taghir_pass();
            object_taghir_pass.ShowDialog();

        }

        private void m_vorod_kala_Click(object sender, EventArgs e)
        {
            Frm_vorod_kala object_vorod_kala = new Frm_vorod_kala();
            object_vorod_kala.ShowDialog();

        }

        private void m_korog_kala_Click(object sender, EventArgs e)
        {
            Frm_khoroj_kala object_khoroje_kala = new Frm_khoroj_kala();
            object_khoroje_kala.ShowDialog();

        }

        private void m_kala_myob_Click(object sender, EventArgs e)
        {
            frm_kalaye_mayob object_kalaye_mayob = new frm_kalaye_mayob();

            object_kalaye_mayob.ShowDialog();


        }

        private void m_gozaresh_vorod_kala_Click(object sender, EventArgs e)
        {
            Frm_gozaresh_vorod_kala object_gozaresh_vorod = new Frm_gozaresh_vorod_kala();
            object_gozaresh_vorod.ShowDialog();


        }

        private void m_kozaresh_khoroge_kala_Click(object sender, EventArgs e)
        {
            Frm_gozaresh_khoroje_kala obj_khoje_kala = new Frm_gozaresh_khoroje_kala();
            obj_khoje_kala.ShowDialog();

        }

        private void m_report_kala_mayob_Click(object sender, EventArgs e)
        {
            frm_gozaresh_kalaye_mayob obj_kalaye_mayob = new frm_gozaresh_kalaye_mayob();
            obj_kalaye_mayob.ShowDialog();
        }

        private void m_about_Click(object sender, EventArgs e)
        {
            frm_about obj_about = new frm_about();
            obj_about.ShowDialog();

        }

        private void lbl_name_family_Click(object sender, EventArgs e)
        {

        }
    }
}
