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
    public partial class admin_enter : Form
    {
        public admin_enter()
        {
            InitializeComponent();
        }
        Admin_Sayfasi admin_pages = new Admin_Sayfasi();
        Db_Connection_str str = new Db_Connection_str();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT* FROM admin WHERE kullanıcı_adi=@user AND sifre=@pass   ;",str.ConToDB());
            command.Parameters.AddWithValue("@user", textBox1.Text);
            command.Parameters.AddWithValue("@pass", textBox2.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read()) { MessageBox.Show("geçerli giriş");this.Hide();admin_pages.Show(); }
            else { MessageBox.Show("oopst! kullanıcı adı veyaşifre yanlış. lütfen kontrol edip tekrar deneyin");                    }
        }
    }
}
