using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem
{
    class DBConnect
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader reader;
        private string con;
        string query;

        public string myConnection()
        {
            con = "Data Source=DESKTOP-AI;Initial Catalog=BankDB;Integrated Security=True";

            return con;
        }

        public DataTable getTable(string query)
        {
            connection.ConnectionString = myConnection();
            command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        public void executeQuery(String sql)
        {
            try
            {
                connection.ConnectionString = myConnection();
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                    command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public double ExtractData(string sql)
        {
            connection = new SqlConnection();
            connection.ConnectionString = myConnection();
            connection.Open();
            command = new SqlCommand(sql, connection);
            double data = double.Parse(command.ExecuteScalar().ToString());
            connection.Close();

            return data;
        }

        internal object ExtractData(object p)
        {
            throw new NotImplementedException();
        }
    }

}
