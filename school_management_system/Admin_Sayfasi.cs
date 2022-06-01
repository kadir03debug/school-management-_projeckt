using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_management_system
{
    public partial class Admin_Sayfasi : Form
    {
        public Admin_Sayfasi()
        {
            InitializeComponent();
        }
        ogrencieklemesayfası student_pages = new ogrencieklemesayfası();
        ogrencisilme student_deleted = new ogrencisilme();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            student_pages.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            student_deleted.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ogretmensilme silme = new ogretmensilme();
            silme.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            istatistiksayfası statistic_page = new istatistiksayfası();
            statistic_page.Show();
            this.Hide();
        }
    }
}
