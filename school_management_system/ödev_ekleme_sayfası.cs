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
    public partial class ödev_ekleme_sayfası : Form
    {
        public ödev_ekleme_sayfası()
        {
            InitializeComponent();
        }
        Db_Connection_str str = new Db_Connection_str();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("İNSERT odev VALUES (@id,@ders,@aciklama,@baslangic,@teslim,@ogretmen,@ogrenci", str.ConToDB());
            cmd.Parameters.AddWithValue("id", textBox1.Text);
            cmd.Parameters.AddWithValue("ders", textBox2.Text);
            cmd.Parameters.AddWithValue("acikleme", textBox3.Text);
            cmd.Parameters.AddWithValue("baslangic", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("teslim", textBox4.Text);
            cmd.Parameters.AddWithValue("ogretmen", textBox5.Text);
            cmd.Parameters.AddWithValue("ogrenci", textBox6.Text);
            cmd.ExecuteNonQuery();
            }

        private void ödev_ekleme_sayfası_Load(object sender, EventArgs e)
        {

        }
    }
}
