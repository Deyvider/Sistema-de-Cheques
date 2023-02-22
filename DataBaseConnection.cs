using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Cheques
{
    internal class DataBaseConnection
    {
        string ConnectionData { get; set; }
        string Source { get; set; }
        string User { get; set; }
        string Password { get; set; }
        string DBName { get; set; }

        private SqlConnection Connection;

        public DataBaseConnection(string Source, string User, string Password, string DBName)
        {
            this.Source = Source;
            this.User = User;
            this.Password = Password;
            this.DBName = DBName;
            ConnectionData = $"Data Source={Source};Initial Catalog={DBName};User ID={User};Password={Password}";
            Connection = new SqlConnection(ConnectionData);
        }

        public string VerifyConnection()
        {
            try
            {
                Connection.Open();
                Connection.Close();
                return "Todo OK";
            }
            catch (Exception ex)
            {
                return $"ERROR...\n{ex}";
            }
        }
    }
}
