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
    public partial class Not_Ekleme : Form
    {
        public Not_Ekleme()
        {
            InitializeComponent();
        }
        Db_Connection_str str = new Db_Connection_str();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("İNSERT not values(@ni,@di,@si,@oi,@on) ", str.ConToDB());
            cmd.Parameters.AddWithValue("@ni", textBox1.Text);
            cmd.Parameters.AddWithValue("@di", textBox2.Text)   ;
            cmd.Parameters.AddWithValue("@si", textBox3.Text);
            cmd.Parameters.AddWithValue("@oi", textBox4.Text);
            cmd.Parameters.AddWithValue("@on", textBox5.Text);
            cmd.ExecuteNonQuery();
        }
    }
}
