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
	public partial class CreateAccount : Form
	{
		Account account = new Account();

		public CreateAccount()
		{
			InitializeComponent();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			if (!AccountValidations()) return;

			string name = txtName.Text;
			decimal mount = decimal.Parse(txtMount.Text);
			string bankName = txtBankName.Text;
			string accountNumber = txtAccountNumber.Text;

			if (!account.CreateAccount(mount, name, bankName, accountNumber))
			{
				MessageBox.Show(
					"La cuenta no pudo ser creada",
					"Registro incorrecto",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}
			MessageBox.Show(
				"Cuenta creada correctamente",
				"Registro correcto",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information);
			this.Close();

		}

		private bool AccountValidations()
		{
			decimal deposit = 0;
            if (!decimal.TryParse(txtMount.Text, out deposit))
            {
                MessageBox.Show(
                    "Monto inicial invalido",
                    "Problema en el registro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                CleanTextBoxes();
                return false;
            }

			if(!HelperMethods.IsNumeric(txtAccountNumber.Text))
			{
				MessageBox.Show(
					"Número de cuenta invalido",
					"Problema en el registro",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				CleanTextBoxes();
				return false;
			}

			return true;
		}

		private void CleanTextBoxes()
		{
			txtAccountNumber.Text = "";
			txtMount.Text = "";
			txtBankName.Text = "";
			txtName.Text = "";
		}
	}
}
