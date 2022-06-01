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
    public partial class öğretmen_girişi : Form
    {
        public öğretmen_girişi()
        {
            InitializeComponent();
        }
        öğretmensayfası teacher_p = new öğretmensayfası();
        private void button1_Click(object sender, EventArgs e)
        {
            Db_Connection_str str = new Db_Connection_str();
            
            SqlCommand cmd = new SqlCommand("SELECT * FROM ogretmen WHERE kullanici_adi LIKE @user AND Sifre LIKE @pass",str.ConToDB());
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);
           SqlDataReader dr= cmd.ExecuteReader();
            if (dr.Read()) { MessageBox.Show("geçerli giriş");teacher_p.Show();this.Hide(); } else { MessageBox.Show("ooops,kullanıcı adıveya şifre  yanlış, lütfen tekrar deneyin"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            


        }
    }
}
