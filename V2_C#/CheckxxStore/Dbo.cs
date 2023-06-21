using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CheckxxStore
{
    internal class Dbo
    {
        private SqlConnection connection;
        private String connectionString = "Data Source=VIPER17\\SQL17;Integrated Security=True";
        private SqlDataReader reader;


        public Dbo(String query)
        {
            connect();
            applyQuery(query);

        }
        private void connect()
        {

            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in sql connexion  : " + ex.Message);
            }

        }
        private void applyQuery(String query)
        {
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in the query : " + ex.Message);
            }
        }


        public SqlConnection getConnection()
        {
            return this.connection;
        }
        public string getConnectionString()
        {
            return this.connectionString;
        }
        public SqlDataReader getReader()
        {
            return this.reader;

        }
    }
}        
