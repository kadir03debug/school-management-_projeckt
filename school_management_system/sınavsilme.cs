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
    public partial class sınavsilme : Form
    {
        public sınavsilme()
        {
            InitializeComponent();
        }
        Db_Connection_str str = new Db_Connection_str();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM sinav WHERE sİNAV_İD=@id;", str.ConToDB());
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.ExecuteNonQuery();
        }
    }
}
