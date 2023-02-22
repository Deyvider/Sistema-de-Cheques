using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Cheques
{
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        // Placeholders para los TextBoxes
        string phName = "Nombre";
        string phUsername = "Usuario";
        string phPassword = "Contraseña";
        string phConfirmPassword = "Confirmar contraseña";
        string phInitialState = "Saldo inicial";

        DataBaseConnection dataBase = new DataBaseConnection("DESKTOP-5JB90L7\\SQLEXPRESS", "paco", "1234", "SistemaDeCheques");

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtName, phName);

        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtName, phName);
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtUsename, phUsername);

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtUsename, phUsername);
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtPassword, phPassword);
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtPassword, phPassword);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtConfirmPassword, phConfirmPassword);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtConfirmPassword, phConfirmPassword);
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtInitialState, phInitialState);
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtInitialState, phInitialState);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string username = txtUsename.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string initialState = txtInitialState.Text;

            // Verificación de que todos los TextBoxes tiene contenido
            if (!IsDataValid())
            {
                MessageBox.Show("Debes llenar todos los campos para poder continuar", 
                                "Problema en el registro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Verifación de igualdad entre contraseñas
            if (!password.Equals(confirmPassword))
            {
                MessageBox.Show("Las contraseñas ingresadas son diferentes",
                                "Problema en el registro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                CleanTextBoxes();
                return;
            }

            // Verificación de saldo inicial valido
            bool isNumeric = initialState.All(char.IsDigit);
            if (!isNumeric)
            {
                MessageBox.Show("El saldo inicial debe ser numerico",
                                "Problema en el registro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                HelperMethods.placeholderDesign(txtInitialState, phInitialState);
                txtInitialState.Focus();
                return;
            }



            // Creación de usuario y creación de cuenta
            string query = $"INSERT INTO [Users] values ('{username}', '{name}', '{password}');";
            SqlCommand command = new SqlCommand(query, dataBase.Connection);
            try
            {
                dataBase.Connection.Open();
                command.ExecuteNonQuery();
                query = "INSERT INTO [Accounts] values (" +
                        $"(SELECT id FROM [Users] where username='{username}')," +
                        $"{initialState}," +
                        $"{initialState});";
                command.CommandText = query;
                command.ExecuteNonQuery();
                MessageBox.Show(
                    $"Usuario '{username}' creado exitosamente",
                    "Registro de usuario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error {ex}");
            }
            finally
            {
                dataBase.Connection.Close();
            }
        }

        private void CleanTextBoxes()
        {
            HelperMethods.placeholderDesign(txtPassword, phPassword);
            txtPassword.UseSystemPasswordChar = false;
            HelperMethods.placeholderDesign(txtConfirmPassword, phConfirmPassword);
            txtConfirmPassword.UseSystemPasswordChar = false;
        }

        private bool IsDataValid()
        {
            bool verification = txtName.Text.Contains(phName)
                                || txtPassword.Text.Contains(phPassword)
                                || txtInitialState.Text.Contains(phInitialState)
                                || txtConfirmPassword.Text.Contains(phConfirmPassword)
                                || txtUsename.Text.Contains(phUsername);
            return !verification;
        }
    }
}
