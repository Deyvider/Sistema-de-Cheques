using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Sistema_de_Cheques
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private string phUsername = "Usuario";
        private string phPassword = "Contraseña";

        DataBaseConnection dataBase = new DataBaseConnection();

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void RealeseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
         

        private void textBox1_Enter(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtUser, phUsername);
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtUser, phUsername);
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtPassword, phPassword);
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtPassword, phPassword);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            RealeseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            RealeseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpPage form2 = new SignUpPage();
            form2.Show();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Verificar que todos los campos tengan texto
            if (!IsDataValid())
            {
                MessageBox.Show("Debes llenar todos los campos para poder continuar",
                                "Problema en el registro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            string username = txtUser.Text;
            string password = txtPassword.Text;

            string query = $"SELECT [id], [name], [username], [balance] FROM [Accounts] where username = '{username}' AND password = '{password}'";
            SqlCommand command = new SqlCommand(query, dataBase.Connection);
            try
            {
                dataBase.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader != null)
                {
                    if (reader.Read())
                    {
                        HomePage homePage = new HomePage();
                        //MessageBox.Show($"Bienvenido {reader.GetString(0)}");
                        Account.Id = reader.GetInt32(0);
                        Account.Name = reader.GetString(1);
                        Account.Username = reader.GetString(2);
                        Account.Balance = reader.GetDecimal(3);
                        CleanTextBoxes();
                        this.Visible = false;
                        homePage.Show();
                    } else
                    {
                        MessageBox.Show(
                            "Usuario o contraseña erroneos",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                        CleanTextBoxes();
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Sin información",
                        "",
                        MessageBoxButtons.OK
                    );
                }

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
        private bool IsDataValid()
        {
            bool verification = txtUser.Text.Contains(phUsername)
                                || txtPassword.Text.Contains(phPassword);
            return !verification;
        }

        private void CleanTextBoxes()
        {
            HelperMethods.placeholderDesign(txtUser, phUsername);
            HelperMethods.placeholderDesign(txtPassword, phPassword);
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage home= new HomePage();
            home.Show();
        }
    }
}