using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmamForms
{
    class dbConnection
    {
        SqlConnection conn;
        public dbConnection()
        {
            string connectionString = "Server=localhost;Database=smam;Uid=root;Pwd=;";
            conn = new SqlConnection(connectionString);
            try
            {

            }
            catch (Exception)
            {
                MessageBox.Show("not connected");
            }
        }

        
    }
}
