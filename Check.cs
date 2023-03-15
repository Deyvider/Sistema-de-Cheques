using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Cheques
{
    internal class Check
    {
        public int Id { get; set; }
        public string Invoice { get; set; }
        public decimal Mount { get; set; }
        public DateTime Date { get; set; }
        public int Beneficiary { get; set; }
        public int Concept { get; set; }
        public int Account { get; set; }
        public bool State { get; set; }

        private DataBaseConnection dataBase = new DataBaseConnection();

        private Account account = new Account();
        
        public Check() { }

        public Check(int id, string invoice, decimal mount, DateTime date, int beneficiary, int concept, int account, bool state)
        {
            Id = id;
            Invoice = invoice;
            Mount = mount;
            Date = date;
            Beneficiary = beneficiary;
            Concept = concept;
            Account = account;
            State = state;
        }
        /*
            Metodo para agregar un nuevo beneficiario a la base de datos
        */

        private int GetLastInvoice()
        {
            string query = "SELECT COUNT(id)," +
                            "(SELECT TOP 1 invoice FROM [Checks] order by id desc)," +
                            "(SELECT firstInvoice FROM [Accounts] WHERE id = 1)," +
                            "(SELECT lastInvoice FROM [Accounts] WHERE id = 1) FROM [Checks];";

            SqlCommand command = new SqlCommand(query, dataBase.Connection);
            try
            {
                dataBase.Connection.Open();
                command.CommandText = query;
                SqlDataReader checksSQL = command.ExecuteReader();
                int total = 0;
                int lastCheck = 0;
                int firstInvoice = 0;
                int lastInvoice = 0;
                if (checksSQL != null)
                {
                    while (checksSQL.Read())
                    {
                        // id, nombre, dirección, telefono, descripcion, estado
                        total = checksSQL.GetInt32(0);
                        lastCheck = total != 0 ? int.Parse(checksSQL.GetString(1)) : 0;
                        firstInvoice = checksSQL.GetInt32(2);
                        lastInvoice = checksSQL.GetInt32(3);
                    }
                }
                if (lastCheck == lastInvoice) return -1;

                return firstInvoice + total;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error, {ex}",
                    "",
                    MessageBoxButtons.OK
                );
            }
            finally
            {
                dataBase.Connection.Close();
            }
            return -1;
        }

        public void CreateCheckSQL(decimal mount, DateTime date, int beneficiary, int concept)
        {
            int invoice = GetLastInvoice();
            if (invoice == -1)
            {
                MessageBox.Show(
                    $"Haz llegado al limite de tu chequera",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }
            string query = "INSERT INTO [Checks] values (" +
                        $"'{invoice}'," +
                        $"{beneficiary}," +
                        $"{mount}," +
                        $"'{date.Year}-{date.Month}-{date.Day}'," +
                        $"1," +
                        $"{User.ActiveAccount.Id}," +
                        $"{concept});";
            //string query = "INSERT INTO [CHECKS] VALUES ('2', 1, 80, '2023/12/28', 1, 1, 1)";
            SqlCommand command = new SqlCommand(query, dataBase.Connection);
            try
            {
                dataBase.Connection.Open();
                command.CommandText = query;
                command.ExecuteNonQuery();
                MessageBox.Show(
                    $"Cheque registrado exitosamente",
                    "Registro de cheques",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                account.MakeDeposit(-mount);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Sin información {ex}",
                    "",
                    MessageBoxButtons.OK
                );
            }
            finally
            {
                dataBase.Connection.Close();
            }
        }

        /*
            Metodo que retorna una lista con todos los cheques registrado
         */
        public List<Check> GetChecksSLQ()
        {
            string query = "SELECT *  FROM [Checks]";
            SqlCommand command = new SqlCommand(query, dataBase.Connection);
            List<Check> chekcs = new List<Check>();
            try
            {
                dataBase.Connection.Open();
                command.CommandText = query;
                SqlDataReader checksSQL = command.ExecuteReader();
                if (checksSQL != null)
                {
                    while (checksSQL.Read())
                    {
                        // id, nombre, dirección, telefono, descripcion, estado
                        int id = checksSQL.GetInt32(0);
                        string invoice = checksSQL.GetString(1);
                        int beneficiary = checksSQL.GetInt32(2);
                        decimal mount = checksSQL.GetDecimal(3);
                        DateTime date = checksSQL.GetDateTime(4);
                        bool state = checksSQL.GetBoolean(5);
                        int account = checksSQL.GetInt32(6);
                        int concept = checksSQL.GetInt32(7);
                        chekcs.Add(new Check(id, invoice, mount, date, beneficiary, concept, account, state));
                    }
                }
                return chekcs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error, {ex}",
                    "",
                    MessageBoxButtons.OK
                );
            }
            finally
            {
                dataBase.Connection.Close();
            }
            return chekcs;
        }
    }
}
