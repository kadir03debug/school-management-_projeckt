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
    public partial class notsilme : Form
    {
        public notsilme()
        {
            InitializeComponent();
        }
        Db_Connection_str str = new Db_Connection_str();
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("yazdığınız not ıd'sine karşılık gelen not silinecek!");
            SqlCommand cmd = new SqlCommand("DELETE FROM not WHERE not_ID=@id;", str.ConToDB());
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.ExecuteNonQuery();
        }   
    }
}
