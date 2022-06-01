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
    public partial class öğretmensayfası : Form
    {
        public öğretmensayfası()
        {
            InitializeComponent();
        }
        Db_Connection_str str = new Db_Connection_str();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            SqlCommand cmd = new SqlCommand("SELECT* FROM ogrenci;", str.ConToDB());
            DataTable dt = new DataTable();
            SqlDataReader dr =cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            SqlCommand cmd = new SqlCommand("SELECT* FROM ders;", str.ConToDB());
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            SqlCommand cmd = new SqlCommand("SELECT* FROM odev", str.ConToDB());
            DataTable dt = new DataTable();
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);dataGridView1.DataSource = dt;

        }

        private void öğretmensayfası_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ogrencieklemesayfası st = new ogrencieklemesayfası();
            st.Show();
            this.Hide();
        }
        ödev_ekleme_sayfası öd = new ödev_ekleme_sayfası();
        private void button5_Click(object sender, EventArgs e)
        {
           öd .Show();
            this.Hide();

        }
        ogrencisilme delete = new ogrencisilme();
        private void button6_Click(object sender, EventArgs e)
        {
            delete.Show();
            this.Hide();    
        }
    }
}
