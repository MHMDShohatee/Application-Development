using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARMSWinClient
{
    public partial class frmCreditCardMSForm : Form
    {
        public frmCreditCardMSForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmCreditCardSearch objCSearch = new frmCreditCardSearch();

            this.Hide();

            objCSearch.ShowDialog();

            this.Show();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            frmCreditCardRegistration objCRegister = new frmCreditCardRegistration();

            this.Hide();

            objCRegister.ShowDialog();

            this.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            frmCreditCardList objCList = new frmCreditCardList();

            this.Hide();

            objCList.ShowDialog();

            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmCreditCardUpdate objCUpdate = new frmCreditCardUpdate();

            this.Hide();

            objCUpdate.ShowDialog();

            this.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmCreditCardDelete objCDelete = new frmCreditCardDelete();

            this.Hide();

            objCDelete.ShowDialog();

            this.Show();
        }
    }
}
