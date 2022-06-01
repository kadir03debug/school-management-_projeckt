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
    public partial class ogrencisilme : Form
    {
        public ogrencisilme()
        {
            InitializeComponent();
        }
        Db_Connection_str str = new Db_Connection_str();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM ogrenci where Ogrenci_adi=@ad    ",str.ConToDB());

            cmd.Parameters.AddWithValue("@ad", textBox1.Text);

                    cmd.ExecuteNonQuery();
            
        }
    }
}
