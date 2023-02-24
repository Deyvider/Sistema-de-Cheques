using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Cheques
{
    internal class Account
    {
        public static int Id { get; set; }
        public static decimal Balance { get; set; }
        public static string Name { get; set; }
        public static string Username { get; set; }

        private DataBaseConnection dataBase = new DataBaseConnection("DESKTOP-5JB90L7\\SQLEXPRESS", "paco", "1234", "SistemaDeCheques");


        public void MakeDeposit(decimal total)
        {
            Balance += total;
            string query = $"UPDATE [Accounts] SET [balance] = {Balance} WHERE [username]='{Username}';";
            SqlCommand command = new SqlCommand(query, dataBase.Connection);
            try
            {
                dataBase.Connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ocurrio un error",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            finally
            {
                dataBase.Connection.Close();
            }

        }
    }
}
