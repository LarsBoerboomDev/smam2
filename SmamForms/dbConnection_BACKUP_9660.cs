using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
<<<<<<< HEAD
        MySqlConnection conn;
        public dbConnection()
        {
            string connectionString = "Server=localhost;Database=smamdb;Uid=root;Pwd=;";
=======
        private MySqlConnection conn;
        private string connectionString;
        private string output;
        private StreamWriter sw;

        public dbConnection()
        {
            connectionString = "Server=localhost;Database=smamdb;Uid=root;Pwd=;";
>>>>>>> feature/articlequery
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
        public Hint getHint()
        {
            DataTable table = new DataTable();
            conn.Open();
            string query = "SELECT * FROM `hint` ORDER BY RAND() LIMIT 1;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();
            myAdapter.SelectCommand = cmd;
            myAdapter.Fill(table);
            conn.Close();
            Hint hint = new Hint();
            foreach (DataRow item in table.Rows)
            {
                hint.Id = item["idHints"].ToString();
                hint.Name = item["Name"].ToString();
                hint.Body = item["Description"].ToString();
            }
            return hint;

<<<<<<< HEAD
        }
        public List<string> getGroceryTypes()
        {
            DataTable table = new DataTable();
            conn.Open();
            string query = "SELECT * FROM `grocery`";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();
            myAdapter.SelectCommand = cmd;
            myAdapter.Fill(table);
            conn.Close();
            List<string> types = new List<string>();
            foreach (DataRow item in table.Rows)
            {
                types.Add(item["Name"].ToString());
            }
            return types;
        }
        private string getGroceryId(string type)
        {
            DataTable table = new DataTable();
            
            string query = "SELECT * FROM `grocery` WHERE grocery.Name = '" + type + "'" ;
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();
            myAdapter.SelectCommand = cmd;
            myAdapter.Fill(table);
            
            string id = "";
            foreach (DataRow item in table.Rows)
            {
                id = item["idGrocery"].ToString();
            }
            return id;
        }
        public List<string> getGroceryProducts(string type)
        {
            DataTable table = new DataTable();
            conn.Open();
            string query = " SELECT * FROM `groceryproduct` " +
                "INNER JOIN groceries_has_grocery ON groceries_has_grocery.Groceries_idGroceries=groceryproduct.idGroceries " +
                "WHERE groceries_has_grocery.Grocery_idGrocery=" + getGroceryId(type);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();
            myAdapter.SelectCommand = cmd;
            myAdapter.Fill(table);
            conn.Close();
            List<string> products = new List<string>();
            foreach (DataRow item in table.Rows)
            {
                products.Add(item["Name"].ToString());
            }
            return products;
=======
        public override string ToString()
        {
            return connectionString.ToString();
>>>>>>> feature/articlequery
        }
    }
}
