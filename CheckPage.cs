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
    public partial class CheckPage : Form
    {
        public CheckPage()
        {
            InitializeComponent();
            InitCBBeneficiaries();
            InitCBConcepts();
            UpdateChecksTable();
        }

        Concept conceptSQL = new Concept();
        Beneficiary beneficiarySQL = new Beneficiary();
        Check checkSQL = new Check();

        private void btnReporte_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{dateTimePicker.Value.ToShortDateString()}");
        }

        /**
            Metodo que ejecuta la limpieza del formulario de registro de cheques
        */
        private void btnDepositar_Click(object sender, EventArgs e)
        {
            CleanTextBoxes();
        }

        /**
            Metodo que ejecuta la creación de nuevo cheque en la base de datos
        */
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (CheckValidations()) return;
            decimal mount = Decimal.Parse(txtMount.Text);
            int beneficiary = (cbBeneficiaries.SelectedIndex + 1);
            int concept = (cbConcepts.SelectedIndex + 1);
            DateTime date = dateTimePicker.Value;
            checkSQL.CreateCheckSQL(mount, date, beneficiary, concept);
            CleanTextBoxes();
            UpdateChecksTable();
        }

        /**
            Metodo para limpiar los campos del formulario de registro
        */
        private void CleanTextBoxes()
        {
            txtMount.Text = "";
            cbBeneficiaries.SelectedIndex = -1;
            cbConcepts.SelectedIndex = -1;
        }

        /**
            Metodo que realiza todas la validaciones necesarias para poder registrar un cheque
        */
        private bool CheckValidations()
        {
            bool validMount = true;
            bool checkInvalid = !HelperMethods.IsNumeric(txtMount.Text) 
                || cbBeneficiaries.SelectedIndex == -1 
                || cbConcepts.SelectedIndex == -1;

            if (txtMount.Text.Equals("") || cbBeneficiaries.SelectedIndex == -1 || cbConcepts.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debes llenar todos los campos",
                    "Problema con el deposito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return true;
            }

            if (!HelperMethods.IsNumeric(txtMount.Text))
            {
                MessageBox.Show(
                    "Solo puedes ingresar montos numericas",
                    "Problema con el deposito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtMount.Text = null;
                txtMount.Focus();
            } else
            {
                if (Decimal.Parse(txtMount.Text) > User.ActiveAccount.Balance)
                {
                    MessageBox.Show(
                        "No hay fondos suficientes para el deposito",
                        "Problema con el deposito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtMount.Text = null;
                    txtMount.Focus();
                    validMount = false;
                }
            }

            return (checkInvalid || !validMount);
        }

        /**
            Metodo que despliega la ventana de busqueda de cheques mediante filtros
        */
        private void button1_Click(object sender, EventArgs e)
        {
            Form6 frmDos = new Form6();
            frmDos.ShowDialog();
        }

        /**
            Metodo que actualiza los datos la tabla que muestra los cheques registrados por el usuario
        */
        private void UpdateChecksTable()
        {
            checksTable.Rows.Clear();
            foreach (Check check in checkSQL.GetChecksSLQ())
            {
                int fila = checksTable.Rows.Add();
                checksTable.Rows[fila].Cells[0].Value = check.Invoice;
                checksTable.Rows[fila].Cells[1].Value = beneficiarySQL.GetBeneficiarySQL(check.Beneficiary).Name;
                checksTable.Rows[fila].Cells[2].Value = check.Mount;
                checksTable.Rows[fila].Cells[3].Value = check.Date.ToShortDateString();
            }
        }

        /**
            Metodo que carga los conceptos disponibles dentro del combo box
        */
        private void InitCBConcepts()
        {
            cbConcepts.Items.Clear();

            foreach (Concept concept in conceptSQL.GetConceptsSLQ())
            {
                cbConcepts.Items.Add(concept.Name);
            }
        }


        /**
            Metodo que carga los beneficiarios disponibles dentro del combo box
        */
        private void InitCBBeneficiaries()
        {
            cbBeneficiaries.Items.Clear();

            foreach (Beneficiary beneficiary in beneficiarySQL.GetBeneficiariesSLQ())
            {
                int row = cbBeneficiaries.Items.Add(beneficiary.Name);
            }
        }
    }
}
