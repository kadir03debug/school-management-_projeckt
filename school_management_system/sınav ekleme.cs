﻿using System;
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
    public partial class sınav_ekleme : Form
    {
        public sınav_ekleme()
        {
            InitializeComponent();
        }
        Db_Connection_str str = new Db_Connection_str();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("İNSERT sınav VALUES (@id,@ders,@tarih);", str.ConToDB());
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@ders", textBox2.Text);
            cmd.Parameters.AddWithValue("@tarih", textBox3.Text);
            cmd.ExecuteNonQuery();



        }
    }
}
