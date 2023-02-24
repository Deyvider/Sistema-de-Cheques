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

        private DataBaseConnection dataBase = new DataBaseConnection();

        private Account account = new Account();
        
        public Check() { }

        public Check(int id, string invoice, decimal mount, DateTime date, int beneficiary, int concept)
        {
            Id = id;
            Invoice = invoice;
            Mount = mount;
            Date = date;
            Beneficiary = beneficiary;
            Concept = concept;
        }

        // Metodo para agregar un nuevo beneficiario a la base de datos
        public void CreateCheckSQL(string invoice, decimal mount, DateTime date, int beneficiary, int concept)
        {
            string query = "INSERT INTO [Checks] values (" +
                        $"'{invoice}'," +
                        $"{mount}," +
                        $"'{date.Month}/{date.Day}/{date.Year}'," +
                        $"{Account.Id}," +
                        $"{beneficiary}," +
                        $"{concept});";
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

        // Metodo que retorna una lista con todos los beneficiarios
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
                        decimal mount = checksSQL.GetDecimal(2);
                        DateTime date = checksSQL.GetDateTime(3);
                        int beneficiary = checksSQL.GetInt32(5);
                        int concept = checksSQL.GetInt32(6);
                        chekcs.Add(new Check(id, invoice, mount, date, beneficiary, concept));
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
