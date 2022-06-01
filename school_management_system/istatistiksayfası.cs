using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace school_management_system
{
    public partial class istatistiksayfası : Form
    {
        public istatistiksayfası()
        {
            InitializeComponent();
        }
        Db_Connection_str str = new Db_Connection_str();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM ogrenci;", str.ConToDB());
            var result = cmd.ExecuteScalar(); 
            MessageBox.Show("okulda bulunan öğrenci sayısı:" + result.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select count(*) from ogretmen;", str.ConToDB());
            var result = cmd.ExecuteScalar();
            MessageBox.Show("okuldaki öğretmen sayısı" + result.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select max(ogrenci_notu) from not;", str.ConToDB());
            var value = cmd.ExecuteScalar();
            MessageBox.Show("okul öğrencilerinin en yüksek not değeri" + value.ToString());
        }
    }
}
