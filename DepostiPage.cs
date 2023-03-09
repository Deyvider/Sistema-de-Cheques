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
    public partial class DepostiPage : Form
    {
        AccountPage accountPageReference;

        public DepostiPage(AccountPage accountPage)
        {
            InitializeComponent();
            this.accountPageReference = accountPage;
        }

        /**
            Metodo que ejecuta el cierre de la ventana actual
        */
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
            Metodo que realiza el deposito dentro de la cuenta del usuario
        */
        private void button4_Click(object sender, EventArgs e)
        {
            decimal deposit = 0;
            if (!decimal.TryParse(txtDeposit.Text,out deposit))
            {
                MessageBox.Show(
                    "Solo puedes depositar cantidades numericas",
                    "Problema en el deposito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtDeposit.Text = null;
                return;
            }
            if (deposit <= 0) 
            {
                MessageBox.Show(
                        "Solo puedes depositar cantidades positivas",
                        "Problema en el deposito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                txtDeposit.Text = null;
                return;
            }
            Account account = new Account();
            account.MakeDeposit(deposit);
            this.accountPageReference.InitTextBoxes();
            this.Close();
        }
    }
}
