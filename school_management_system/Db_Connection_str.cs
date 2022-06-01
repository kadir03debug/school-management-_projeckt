using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace school_management_system
{
    class Db_Connection_str
    {
        public SqlConnection ConToDB() {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2V81BGFJ\SQLEXPRESS;Initial Catalog=okul;Integrated Security=True");
            con.Open();
            return con;
        }





    }
}
