using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Sistema_de_Cheques
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        DataBaseConnection dataBase = new DataBaseConnection("DESKTOP-5JB90L7\\SQLEXPRESS","paco", "1234", "SistemaDeCheques");

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void RealeseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
         

        private void textBox1_Enter(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtUser, "Usuario");
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtUser, "Usuario");
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtPassword, "Contraseña");
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtPassword, "Contraseña");
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

            // MessageBox.Show(dataBase.VerifyConnection());
        }
    }
}