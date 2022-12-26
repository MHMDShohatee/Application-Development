using ARMSBOLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARMSWinClient
{
    public partial class frmCreditCardSearch : Form
    {
        CreditCard objCreditCard;
        public frmCreditCardSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //Step1 - Create a Customer Object 
                //IN OUR CASE INSTEAD OF CREATING A CUSTOMER OBJECT,
                // YOU CREATE A CREDITCARD OBJECT!
                objCreditCard = new CreditCard();

                //Call Customer Object Load(ID) method to execute SELECT query
                //to the database and populate itself with the record returned
                //from the query
                //IN OUR CASE INSTEAD OF CALLING A CUSTOMER OBJECT LOAD(KEY) METHOD
                // YOU CALL A CREDITCARD OBJECT LOAD(KEY) METHOD!
                bool success = objCreditCard.Load(txtCardNumber.Text.Trim());


                //Step 2-If validate customer is found 

                if (success)
                {

                    //Step 3-Then Data is extracted (GET the properties)from customer object & placed on textboxes
                    //IN OUR CASE INSTEAD OF SETTING THE FORM CONTROLS WITH DATA FROM 
                    //ALL THE GET PROPERTY OF A CUSTOMER OBJECT, YOU GET THE PROPERTIES
                    //OF  A CREDITCARD OBJECT!
                    //BUT OUR TEXT BOXES & CONTROLS HAVE DIFFERENT NAMES ETC.
                    //BASED ON OUR NAMING CONVENTION AND OUR SEARCH FORM
                    txtCCNumber.Text = objCreditCard.CreditCardNumber;
                    txtCOName.Text = objCreditCard.CreditCardOwnerName;
                    txtCCCompany.Text = objCreditCard.CreditCardIssuingCompany;
                    txtMerchantCode.Text = objCreditCard.MerchantCode.ToString();
                    txtExpDate.Text = objCreditCard.ExpDate.ToString();
                    txtAddr1.Text = objCreditCard.AddressLine1;
                    txtAddr2.Text = objCreditCard.AddressLine2;     //convert to a string 
                    txtCity.Text = objCreditCard.City;
                    txtState.Text = objCreditCard.StateCode;
                    txtZipCode.Text = objCreditCard.ZipCode;
                    txtCountry.Text = objCreditCard.Country;
                    txtCCLimit.Text = objCreditCard.CreditCardLimit.ToString();
                    txtCCBalance.Text = objCreditCard.CreditCardBalance.ToString();
                    txtActiveStatus.Text = objCreditCard.ActivationStatus.ToString();
                }

                else
                {
                    //Step 4-prompt user customer not found
                    //IN OUR CASE INSTEAD OF MESSAGING CUSTOMER NOT FOUND,
                    //MESSAGE CREDITCARD NOT FOUND!
                    MessageBox.Show("Credit Card Not Found");

                    //Step 5-Clear all controls
                    //IN OUR CASE INSTEAD WE WOULD CLEAR THE CONTROLS USING,
                    //THE NAMES FROM OUR SEARCH FORM!
                    txtCCNumber.Text = "";
                    txtCOName.Text = "";
                    txtCCCompany.Text = "";
                    txtMerchantCode.Text = "";
                    txtExpDate.Text = "";
                    txtAddr1.Text = "";
                    txtAddr2.Text = "";    //convert to a string 
                    txtCity.Text = "";
                    txtState.Text = "";
                    txtZipCode.Text = "";
                    txtCountry.Text = "";
                    txtCCLimit.Text = "";
                    txtCCBalance.Text = "";
                    txtActiveStatus.Text = "";

                }
            }//End of try
            //Step B-Trap for BO, App & General Exceptions
            catch (System.Exception)
            {
                //Step C- Respond to user with message;
                MessageBox.Show("Error in search!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmCreditCardMSForm objCMS = new frmCreditCardMSForm();

            this.Hide();

            objCMS.ShowDialog();

            this.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            objCreditCard.Print();
        }
    }
}
