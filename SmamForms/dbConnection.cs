using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SmamForms
{
    class dbConnection
    {

        MySqlConnection conn;         
        private string connectionString;
        private string output;

        public dbConnection()
        {
            connectionString = "Server=localhost;Database=smamdb;Uid=root;Pwd=;";

            try
            {
                conn = new MySqlConnection(connectionString);
            }
            catch (Exception exception)
            {
                ExceptionToText ex = new ExceptionToText(exception.ToString());
            }
        }

        public string GetArticleText(string articlename) //tekst van een artikel ophalen
        {
            if (conn == null)
            {
                conn = new MySqlConnection(connectionString);
            }
            string query = "SELECT * FROM article WHERE Name = '" + articlename + "'";
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
            try
            {
                conn.Open();
            }
            catch (Exception exception)
            {
                ExceptionToText ex = new ExceptionToText(exception.ToString());
                return null;
            }
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
        }

        public List<string> GetImageURL(string articleID)
        {
            if (conn == null)
            {
                conn = new MySqlConnection(connectionString);
            }
            string query = "SELECT URL FROM `image` WHERE Article_idArticles = '" + articleID + "'";
            List<string> articleURL = new List<string>();
            DataTable dataTable = new DataTable();
            MySqlCommand querycmd = new MySqlCommand(query, conn);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = querycmd;
            mySqlDataAdapter.Fill(dataTable);
            foreach (DataRow item in dataTable.Rows)
            {
                articleURL.Add(item["URL"].ToString());
            }
            return articleURL;
        }

        public string GetArticleID(string articlename)
        {
            if (conn == null)
            {
                conn = new MySqlConnection(connectionString);
            }
            string query = "SELECT `idArticles` FROM `article` WHERE `Name` = '" + articlename + "'";
            DataTable dataTable = new DataTable();
            MySqlCommand querycmd = new MySqlCommand(query, conn);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = querycmd;
            mySqlDataAdapter.Fill(dataTable);
            foreach (DataRow item in dataTable.Rows)
            {
                output = item["idArticles"].ToString();
            }
            return output;
        }

        public override string ToString()
        {
            return connectionString.ToString();

        }
    }
}
