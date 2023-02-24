using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Sistema_de_Cheques
{
    public partial class SearchBeneciaryPage : Form
    {
        public SearchBeneciaryPage()
        {
            InitializeComponent();
        }

        Beneficiary beneficiary = new Beneficiary();
        string phName = "Nombre del beneficiario";
        string phId = "Id";
        string phPhone = "Celular";

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SetEmptyData();
            UpdateBeneficiariesTable();
            CleanTextBoxes();
        }

        private void UpdateBeneficiariesTable()
        {
            beneficiariesTable.Rows.Clear();
            string id = txtId.Text;
            string phone = txtPhone.Text;
            string name = txtName.Text;
            string active = checkBox1.Checked ? "1" : "0";
            foreach (Beneficiary beneficiarySQL in beneficiary.GetBeneficiariesByValuesSQL(id, name, phone, active))
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
            HelperMethods.placeholderDesign(txtId, phId);
            HelperMethods.placeholderDesign(txtPhone, phPhone);
            checkBox1.Checked = false;
        }

        private void SetEmptyData()
        {
            if (txtId.Text.Equals(phId)) txtId.Text = "";
            if (txtName.Text.Equals(phName)) txtName.Text = "";
            if (txtPhone.Text.Equals(phPhone)) txtPhone.Text = "";
        }

        private void txtId_Enter(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtId, phId);
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtId, phId);
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtName, phName);
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtName, phName);
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtPhone, phPhone);
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            HelperMethods.placeholderController(txtPhone, phPhone);
        }
    }
}
