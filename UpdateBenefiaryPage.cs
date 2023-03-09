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
    public partial class UpdateBenefiaryPage : Form
    {
        int benficiaryId;
        BeneficiaryPage beneficiaryPage;
        public UpdateBenefiaryPage(int id, BeneficiaryPage beneficiaryPage)
        {
            InitializeComponent();
            benficiaryId = id;
            this.beneficiaryPage = beneficiaryPage;
        }

        Beneficiary beneficiary = new Beneficiary();


        /*
            Metodo usado para obtener los datos de un beneficiario y los coloca en el 
            formulario de edición
        */
        private void InitTextBoxes()
        {
            Beneficiary beneficiaryInit = beneficiary.GetBeneficiarySQL(benficiaryId);
            txtId.Text = beneficiaryInit.Id.ToString();
            txtName.Text = beneficiaryInit.Name.ToString();
            txtAddress.Text = beneficiaryInit.Address.ToString();
            txtPhone.Text = beneficiaryInit.Phone.ToString();
            txtDescription.Text = beneficiaryInit.Description.ToString();
            cbActive.Checked = beneficiaryInit.Active;
        }

        /*
            Metodo que ejecuta la inicialización de los TextBox
        */
        private void UpdateBenefiaryPage_Load(object sender, EventArgs e)
        {
            InitTextBoxes();
        }

        /*
            Metodo usado para ejecta la actualización de un beneficiario
        */
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Beneficiary beneficiaryUpdated = beneficiary.GetBeneficiarySQL(benficiaryId);
            beneficiaryUpdated.Name = txtName.Text;
            beneficiaryUpdated.Address = txtAddress.Text;
            beneficiaryUpdated.Phone = txtPhone.Text;
            beneficiaryUpdated.Description = txtDescription.Text;
            beneficiaryUpdated.Active = cbActive.Checked;
            beneficiary.UpdateBeneficiary(beneficiaryUpdated);
            beneficiaryPage.UpdateBeneficiariesTable();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void btnName_Click(object sender, EventArgs e)
		{
            txtName.Enabled = !txtName.Enabled;
		}

		private void btnAddress_Click(object sender, EventArgs e)
		{
			txtAddress.Enabled = !txtAddress.Enabled;
		}

		private void btnPhone_Click(object sender, EventArgs e)
		{
            txtPhone.Enabled = !txtPhone.Enabled;
		}

		private void btnDescription_Click(object sender, EventArgs e)
		{
			txtDescription.Enabled = !txtDescription.Enabled;
		}
	}
}
