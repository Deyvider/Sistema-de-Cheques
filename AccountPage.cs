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
    public partial class AccountPage : Form
    {
        public AccountPage()
        {
            InitializeComponent();
            InitTextBoxes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            DepostiPage frmDos = new DepostiPage(this);
            frmDos.ShowDialog();
        }

        public void InitTextBoxes()
        {
            txtSaldo.Text = Account.Balance.ToString();
            txtName.Text = Account.Name.ToString();
            txtUsername.Text = Account.Username.ToString();
        }
    }
}
