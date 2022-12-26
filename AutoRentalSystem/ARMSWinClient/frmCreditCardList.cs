using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ARMSBOLayer;

namespace ARMSWinClient
{
    public partial class frmCreditCardList : Form
    {
        private string strConn = "Data Source= MS\\SQLExpress;Initial Catalog=EZRentalDB;Integrated Security=True";
        public frmCreditCardList()
        {
            InitializeComponent();
        }
        private void frmCreditCardList_Load(object sender, EventArgs e)
        {
            dgvCreditCardList.AutoGenerateColumns = false;
        }
        private void btnListAllCreditCards_Click(object sender, EventArgs e)
        {
            //Set the Data Source - a database table or a collection of creditcard class objects.
            //the CreditCard Class Static GetAllCreditCards() method returns a collection of CreditCard Objects
            dgvCreditCardList.DataSource = CreditCard.GetAllCreditCards();
            //BIND each CreditCard Class Property to each of the DataGridView Data COLUMNS Property Names
            //to automatically display each CreditCard object in collection to all the Data Properties
            //of the DataGridView Control
            dgvCreditCardList.Columns["cohCreditCardNumber"].DataPropertyName = "CreditCardNumber";
            dgvCreditCardList.Columns["cohCreditCardOwnerName"].DataPropertyName = "CreditCardOwnerName";
            dgvCreditCardList.Columns["cohCreditCardIssuingCompany"].DataPropertyName = "CreditCardIssuingCompany";
            dgvCreditCardList.Columns["cohMerchantCode"].DataPropertyName = "MerchantCode";
            dgvCreditCardList.Columns["cohExpirationDate"].DataPropertyName = "ExpDate";
            dgvCreditCardList.Columns["cohAddressLine1"].DataPropertyName = "AddressLine1";
            dgvCreditCardList.Columns["cohAddressLine2"].DataPropertyName = "AddressLine2";
            dgvCreditCardList.Columns["cohCity"].DataPropertyName = "City";
            dgvCreditCardList.Columns["cohState"].DataPropertyName = "State";
            dgvCreditCardList.Columns["cohZipCode"].DataPropertyName = "ZipCode";
            dgvCreditCardList.Columns["cohCountry"].DataPropertyName = "Country";
            dgvCreditCardList.Columns["cohCreditCardLimit"].DataPropertyName = "CreditCardLimit";
            dgvCreditCardList.Columns["cohCreditCardBalance"].DataPropertyName = "CreditCardBalance";
            dgvCreditCardList.Columns["cohActivationStatus"].DataPropertyName = "ActivationStatus";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCreditCardList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
