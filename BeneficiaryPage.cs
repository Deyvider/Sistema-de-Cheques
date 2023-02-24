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
    public partial class BeneficiaryPage : Form
    {
        Beneficiary beneficiary = new Beneficiary();
        string phName = "Nombre";
        string phAddress = "Dirección";
        string phDescription = "Descripción";
        string phPhone = "Celular";

        public BeneficiaryPage()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UpdateBeneficiariesTable();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!IsDataValid())
            {
                MessageBox.Show("Debes llenar todos los campos para poder registrar un beneficiario",
                                "Problema en el registro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            beneficiary.CreateBeneficiarySQL(txtName.Text, txtAddress.Text, txtPhone.Text, txtDescription.Text);
            CleanTextBoxes();
            UpdateBeneficiariesTable();

            //Actualizar tabla de beneficiarios
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            CleanTextBoxes();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 frmDos = new Form5();
            frmDos.ShowDialog();
        }

        private void UpdateBeneficiariesTable()
        {
            beneficiariesTable.Rows.Clear();
            foreach (Beneficiary beneficiarySQL in beneficiary.GetBeneficiariesSLQ())
            {
                int fila = beneficiariesTable.Rows.Add();
                beneficiariesTable.Rows[fila].Cells[0].Value = beneficiarySQL.Id;
                beneficiariesTable.Rows[fila].Cells[1].Value = beneficiarySQL.Name;
                beneficiariesTable.Rows[fila].Cells[2].Value = beneficiarySQL.Phone;
                beneficiariesTable.Rows[fila].Cells[3].Value = beneficiarySQL.Address;
                beneficiariesTable.Rows[fila].Cells[4].Value = beneficiarySQL.Description;
                beneficiariesTable.Rows[fila].Cells[5].Value = beneficiarySQL.Active ? "Activo" : "Inactivo";
            }
        }
        private void CleanTextBoxes()
        {
            HelperMethods.placeholderDesign(txtName, phName);
            HelperMethods.placeholderDesign(txtAddress, phAddress);
            HelperMethods.placeholderDesign(txtDescription, phDescription);
            HelperMethods.placeholderDesign(txtPhone, phPhone);
        }

        private bool IsDataValid()
        {
            bool verification = txtAddress.Text.Equals(phAddress) 
                || txtDescription.Text.Equals(phDescription) 
                || txtName.Text.Equals(phName) 
                || txtPhone.Text.Equals(phPhone);
            return !verification;
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtName, phName);
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtName, phName);
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtAddress, phAddress);
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtAddress, phAddress);
        }

        private void txtDescription_Enter(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtDescription, phDescription);
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtDescription, phDescription);
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtPhone, phPhone);
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtPhone, phPhone);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }




    }




