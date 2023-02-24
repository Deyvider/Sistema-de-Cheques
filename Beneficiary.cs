using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Sistema_de_Cheques
{
    internal class Beneficiary
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

        private DataBaseConnection dataBase = new DataBaseConnection("DESKTOP-5JB90L7\\SQLEXPRESS", "paco", "1234", "SistemaDeCheques");


        public Beneficiary() { }

        public Beneficiary(int id, string name, string address, string phone, string description, bool active) 
        { 
            Id = id;
            Name = name;
            Address = address;
            Phone = phone;
            Description = description;
            Active = active;
        }

        // Metodo para agregar un nuevo beneficiario a la base de datos
        public void CreateBeneficiarySQL(string name, string address, string phone, string description)
        {
            string query = "INSERT INTO [Beneficiaries] values (" +
                        $"'{name}'," +
                        $"'{address}'," +
                        $"'{phone}'," +
                        $"'{description}'," +
                        $"1);";
            SqlCommand command = new SqlCommand(query, dataBase.Connection);
            try
            {
                dataBase.Connection.Open();
                command.CommandText = query;
                command.ExecuteNonQuery();
                MessageBox.Show(
                    $"Beneficiario '{name}' registrado exitosamente",
                    "Registro de beneficiarios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
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
        public List<Beneficiary> GetBeneficiariesSLQ()
        {
            string query = "SELECT *  FROM [Beneficiaries]";
            SqlCommand command = new SqlCommand(query, dataBase.Connection);
            List<Beneficiary> beneficiaries = new List<Beneficiary>();
            try
            {
                dataBase.Connection.Open();
                command.CommandText = query;
                SqlDataReader beneficiariesSQL = command.ExecuteReader();
                if (beneficiariesSQL != null )
                {
                    while(beneficiariesSQL.Read())
                    {
                        // id, nombre, dirección, telefono, descripcion, estado
                        int id = beneficiariesSQL.GetInt32(0);
                        string name = beneficiariesSQL.GetString(1);
                        string address = beneficiariesSQL.GetString(2);
                        string phone = beneficiariesSQL.GetString(3);
                        string description = beneficiariesSQL.GetString(4);
                        bool active = beneficiariesSQL.GetBoolean(5);
                        beneficiaries.Add(new Beneficiary(id, name, address, phone, description, active));
                    }
                }
                return beneficiaries;
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
            return beneficiaries;
        }
    }
}
