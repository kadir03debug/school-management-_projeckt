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
    public partial class derssilme : Form
    {
        public derssilme()
        {
            InitializeComponent();
        }
        Db_Connection_str str = new Db_Connection_str();
        private void derssilme_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM ders where ders_ID=id;", str.ConToDB());
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.ExecuteNonQuery();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
