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

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.MakeDeposit(Decimal.Parse(txtDeposit.Text));
            this.accountPageReference.InitTextBoxes();
            this.Close();
        }
    }
}
