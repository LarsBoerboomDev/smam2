using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace SmamForms
{
    class dbConnection
    {
        private MySqlConnection conn;
        private string connectionString;
        private string output;
        private StreamWriter sw;

        public dbConnection()
        {
            connectionString = "Server=localhost;Database=smamdb;Uid=root;Pwd=;";
            conn = new MySqlConnection(connectionString);
            try
            {

            }
            catch (Exception exception)
            {
                MessageBox.Show("not connected");
                using (sw = File.AppendText(@"D:\exceptionlog.txt")) //tekstbestand maken indien niet bestaat
                {
                    sw.WriteLine(exception.ToString()); //exception details schrijven
                    sw.WriteLine(DateTime.Now.ToLongDateString() + " - " + DateTime.Now.ToLongTimeString()); //tijd en datum schrijven
                    sw.WriteLine(""); //wit regel tovoegen
                }
            }
        }

        public string GetArticleText(string articlename) //tekst van een artikel ophalen
        {
            if (conn == null)
            {
                conn = new MySqlConnection(connectionString);
            }
            string query = "SELECT * FROM article WHERE Name = '" + articlename + "'"; //is test van database
            Console.WriteLine(query);
            DataTable dataTable = new DataTable();
            MySqlCommand querycmd = new MySqlCommand(query, conn);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = querycmd;
            mySqlDataAdapter.Fill(dataTable);
            foreach (DataRow item in dataTable.Rows)
            {
                output = "";
                output = item["Description"].ToString();
            }
            return output;
        }

        public List<string> GetArticleTitles(string type) //alle titels van alle artikelen ophalen van één type
        {
            if (conn == null)
            {
                conn = new MySqlConnection(connectionString);
            }
            string query = "Select * FROM article WHERE types_idtypes = " + type;
            Console.WriteLine(query);
            List<string> articletitles = new List<string>();
            DataTable dataTable = new DataTable();
            MySqlCommand querycmd = new MySqlCommand(query, conn);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = querycmd;
            mySqlDataAdapter.Fill(dataTable);
            foreach (DataRow item in dataTable.Rows)
            {
                articletitles.Add(item["Name"].ToString());
            }
            return articletitles;
        }

        public string GetTypeName(string type)
        {
            if (conn == null)
            {
                conn = new MySqlConnection(connectionString);
            }
            string query = "Select * FROM type WHERE idtypes = " + type;
            Console.WriteLine(query);
            List<string> articletitles = new List<string>();
            DataTable dataTable = new DataTable();
            MySqlCommand querycmd = new MySqlCommand(query, conn);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = querycmd;
            mySqlDataAdapter.Fill(dataTable);
            foreach (DataRow item in dataTable.Rows)
            {
                output = item["typeName"].ToString();
            }
            return output;
        }

        public override string ToString()
        {
            return connectionString.ToString();
        }
    }
}
