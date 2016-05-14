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

namespace AsistenteModerno
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection cnn = Connection.getconnection();

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                cnn.Close();
                MessageBox.Show("Conectado a la base de datos");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
