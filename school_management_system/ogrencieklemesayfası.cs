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
    public partial class ogrencieklemesayfası : Form
    {
        public ogrencieklemesayfası()
        {
            InitializeComponent();
        }
        Db_Connection_str str = new Db_Connection_str();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT ogrenci VALUES (@ıd,@ad,@soyad,@sinif,@alan);", str.ConToDB());
            cmd.Parameters.AddWithValue("@ıd", textBox1.Text);
            cmd.Parameters.AddWithValue("@ad", textBox2.Text);
            cmd.Parameters.AddWithValue("@soyad", textBox3.Text);
            cmd.Parameters.AddWithValue("@sinif", textBox4.Text);
            cmd.Parameters.AddWithValue("@alan", textBox5.Text);
                cmd.ExecuteNonQuery();
        }
    }
}
