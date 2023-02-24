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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{dateTimePicker.Value.ToShortDateString()}");
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            CleanTextBoxes();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (CheckValidations()) return;

            string invoice = txtInvoice.Text;
            decimal mount = Decimal.Parse(txtMount.Text);
            int beneficiary = (cbBeneficiaries.SelectedIndex + 1);
            int concept = (cbConcepts.SelectedIndex + 1);
            DateTime date = dateTimePicker.Value;
            checkSQL.CreateCheckSQL(invoice, mount, date, beneficiary, concept);
            CleanTextBoxes();
            UpdateChecksTable();
        }

        private void CleanTextBoxes()
        {
            txtInvoice.Text = "";
            txtMount.Text = "";
            cbBeneficiaries.SelectedIndex = -1;
            cbConcepts.SelectedIndex = -1;
        }

        private bool CheckValidations()
        {
            bool validMount = true;
            bool checkInvalid = !HelperMethods.IsNumeric(txtMount.Text) 
                || !HelperMethods.IsNumeric(txtInvoice.Text)
                || cbBeneficiaries.SelectedIndex == -1 
                || cbConcepts.SelectedIndex == -1;

            if (txtMount.Text.Equals("") || txtInvoice.Text.Equals("") || cbBeneficiaries.SelectedIndex == -1 || cbConcepts.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debes llenar todos los campos",
                    "Problema con el deposito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtInvoice.Text = null;
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
                if (Decimal.Parse(txtMount.Text) > Account.Balance)
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
            
            if (!HelperMethods.IsNumeric(txtInvoice.Text))
            {
                MessageBox.Show(
                    "El folio debe tener formato numerico",
                    "Problema con el deposito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtInvoice.Text = null;
                txtInvoice.Focus();
            }

            return (checkInvalid || !validMount);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 frmDos = new Form6();
            frmDos.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void UpdateChecksTable()
        {
            checksTable.Rows.Clear();
            foreach (Check check in checkSQL.GetChecksSLQ())
            {
                int fila = checksTable.Rows.Add();
                checksTable.Rows[fila].Cells[0].Value = check.Id;
                checksTable.Rows[fila].Cells[1].Value = check.Invoice;
                checksTable.Rows[fila].Cells[2].Value = beneficiarySQL.GetBeneficiarySQL(check.Beneficiary).Name;
                checksTable.Rows[fila].Cells[3].Value = check.Mount;
                checksTable.Rows[fila].Cells[4].Value = check.Date.ToShortDateString();
                checksTable.Rows[fila].Cells[5].Value = conceptSQL.GetConceptSQL(check.Concept).Name;
            }
        }

        private void InitCBConcepts()
        {
            cbConcepts.Items.Clear();

            foreach (Concept concept in conceptSQL.GetConceptsSLQ())
            {
                cbConcepts.Items.Add(concept.Name);
            }
        }

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
