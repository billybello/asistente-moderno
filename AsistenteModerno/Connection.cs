using System;
using System.Collections.Generic;
using System.Data;
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

        public static DataTable getDataTable(string query)
        {
            SqlConnection cnn = Connection.getconnection();
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            DataTable table = new DataTable();
            da.Fill(table);
            cnn.Close();
            return table;
        }

        public static SqlDataReader getDataReader(string query)
        {
            SqlConnection cnn = Connection.getconnection();
            cnn.Open();
            SqlDataReader dr = null;
            SqlCommand consulta = new SqlCommand(query, cnn);
            consulta.CommandType = CommandType.Text;
            dr = consulta.ExecuteReader();
            cnn.Close();
            return dr;
        }
    }
}
