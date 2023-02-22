using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            HelperMethods.placeholderController(txtUser, "Nombre");

        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtUser, "Nombre");
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(textBox3, "Usuario");

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(textBox3, "Usuario");
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtPassword, "Contraseña");
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtPassword, "Contraseña");
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(textBox1, "Confirmar contraseña");
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(textBox1, "Confirmar contraseña");
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(textBox2, "Saldo Inicial");
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(textBox2, "Saldo Inicial");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
