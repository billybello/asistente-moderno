using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenteModerno
{
    class Connection
    {
        public static SqlConnection getconnection()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\asistentemoderno.mdf;Integrated Security=True");
            return con;
        }
    }
}
