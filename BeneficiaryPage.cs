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

        /**
            Metodo usado para realizar el registro de un beneficiario 
        */
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

            //Actualizar tabla de beneficiarios
            UpdateBeneficiariesTable();

        }

        /**
            Metodo ejecutar la limpieza del formulario de beneficiario
        */
        private void btnDepositar_Click(object sender, EventArgs e)
        {
            CleanTextBoxes();
        }

        /**
            Metodo para desplegar la ventana de busqueda de beneficiarios
        */
        private void button1_Click(object sender, EventArgs e)
        {
            SearchBeneciaryPage frmDos = new SearchBeneciaryPage();
            frmDos.ShowDialog();
        }

        /**
            Metodo acciona la actualización de datos de un beneficiario
        */
        public void UpdateBeneficiariesTable()
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

        /**
            Metodo que limpia los campos del formulario de la pagina
        */
        private void CleanTextBoxes()
        {
            HelperMethods.placeholderDesign(txtName, phName);
            HelperMethods.placeholderDesign(txtAddress, phAddress);
            HelperMethods.placeholderDesign(txtDescription, phDescription);
            HelperMethods.placeholderDesign(txtPhone, phPhone);
        }

        /**
            Metodo que valida que los campos del formulario no esten vacios
        */
        private bool IsDataValid()
        {
            bool verification = txtAddress.Text.Equals("")
                || txtDescription.Text.Equals("") 
                || txtName.Text.Equals("") 
                || txtPhone.Text.Equals("");
            return !verification;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        /**
            Metodo usado para validar si el usuario desea modificar al usuario seleccionada,
            de ser así deplega el formulario de actualización
        */
        private void beneficiariesTable_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = beneficiariesTable.Rows[e.RowIndex];
            int id = int.Parse(row.Cells[0].Value.ToString());
            string name = row.Cells[1].Value.ToString();

            DialogResult result = MessageBox.Show(
                $"¿Quieres actualizar los datos del beneficiario?\n" +
                $"Nombre: {name}",
                "Datos registrados",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
            );

            if (result.ToString().Equals("Yes"))
            {
                UpdateBenefiaryPage updateBenefiary = new UpdateBenefiaryPage(id, this);
                updateBenefiary.Show();
            }
        }
    }




}




