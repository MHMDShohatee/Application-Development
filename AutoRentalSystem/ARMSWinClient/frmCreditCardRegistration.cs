using System;
using ARMSBOLayer;
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
    public partial class frmCreditCardRegistration : Form
    {
        public frmCreditCardRegistration()
        {
            InitializeComponent();
        }

        private void frmCreditCardRegistration_Load(object sender, EventArgs e)
        {
           

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //Step A - start Excption handling
            try
            {
                //Step1 - Create a Customer Object 
                //IN OUR CASE INSTEAD OF CREATING A CUSTOMER OBJECT,
                // YOU CREATE A CREDITCARD OBJECT!
                CreditCard objCreditCard = new CreditCard();


                //SET Object with PROPERTY values
                //IN OUR CASE FOR REGISTRATION WE ARE SETTING THE OBJECT
                //WITH DATA TO SEND IT TO THE DALAYER FOR INSERTING TO DATABASE.
                // SO WE ARE GETTING FROM THE FORM CONTROLS AND SETTING THE
                //OBJECT WITH DATA FROM THE FORM CONTROLS.
                //ALL THE PROPERTY OF A CUSTOMER OBJECT ARE SET THE PROPERTIES
                //OF  A CREDITCARD OBJECT!
                //BUT OUR TEXT BOXES & CONTROLS HAVE DIFFERENT NAMES ETC.
                //BASED ON OUR NAMING CONVENTION AND OUR REGISTRATION FORM
                objCreditCard.CreditCardNumber = txtCCNumber.Text.Trim();
                objCreditCard.CreditCardOwnerName = txtCOName.Text.Trim();
                objCreditCard.CreditCardIssuingCompany = txtCCCompany.Text.Trim();
                objCreditCard.MerchantCode = Convert.ToInt32(txtMerchantCode.Text);
                objCreditCard.ExpDate = dtpExpDate.Value.Date;
                objCreditCard.AddressLine1 = txtAddr1.Text.Trim();
                objCreditCard.AddressLine2 = txtAddr2.Text.Trim();
                objCreditCard.City = txtCity.Text.Trim();
                objCreditCard.StateCode = cbState.SelectedValue.ToString();
                objCreditCard.ZipCode = txtZipCode.Text.Trim();
                objCreditCard.Country = cbCountry.SelectedValue.ToString();
                objCreditCard.CreditCardLimit = Convert.ToDecimal(txtCreditCardLimit.Text);
                objCreditCard.CreditCardBalance = Convert.ToDecimal(txtCreditCardBalance.Text);

                /*
                if (Convert.ToBoolean(cbActivationStatus.Text.Trim()) == true)
                    objCreditCard.Activate();
                else
                    objCreditCard.Deactivate();
                */

                //IMPORTANT************************
                //HERE IS WHERE YOU WILL HAVE A CHALLENGE EXTACTING 
                //THE DATA FROM THE COMBO BOXES AND INTO THE OBJECT!
                //THIS IS WHERE THINGS CAN GET DIFFICULT
                //COMBO BOXES HAVE LOTS OF FEATURES AND WHICH FEATURE
                //YOU USE IS IMPORTANT BASED ON SCENARIO.
                //AFTER THIS EXAMPLE, I WILL PROVIDE THE CODE FOR THIS.
                //IMPORTANT *******************************
                //COME BACK TO THIS SECTION IN YOUR CODE WITH THE CODE
                //I AM GOING TO LIST AFTER THIS EXAMPLE AND PLACE HERE!
                //LETS CONTINUE WITH THE REST OF THE EXAMPLE WHICH YOU NEED
                //TO DO AS WELL BUT IS THE SAME AS THIS ONE 

                //Call Customer Object Insert()) method to execute INSERT query
                //Using the populated object's data to create Insert query
                //IN OUR CASE INSTEAD OF CALLING A CUSTOMER OBJECT INSERT() METHOD
                // YOU CALL A CREDITCARD OBJECT INSERT(KEY) METHOD!
                bool success = objCreditCard.Insert();


                //Step 2-If validate customer was added 
                if (success)
                {
                    //Prompt user customer was added 
                    //IN OUR CASE INSTEAD OF MESSAGING CUSTOMER ADDED,
                    //MESSAGE CREDITCARD ADDED!
                    MessageBox.Show("Credit Card Added");

                    //Step 5-Clear all controls
                    //IN OUR CASE INSTEAD WE WOULD CLEAR THE CONTROLS USING,
                    //THE NAMES FROM OUR REGISTRATION FORM!
                    txtCCNumber.Text = "";
                    txtCOName.Text = "";
                    txtCCCompany.Text = "";
                    txtMerchantCode.Text = "";
                    dtpExpDate.Text = "";
                    txtAddr1.Text = "";
                    txtAddr2.Text = "";
                    txtCity.Text = "";
                    cbState.Text = "";
                    txtZipCode.Text = "";
                    cbCountry.Text = "";
                    txtCreditCardLimit.Text = "";
                    txtCreditCardBalance.Text = "";
                    cbActivationStatus.Text = "";
                }
                else
                {
                    //prompt user customer was not added 
                    //IN OUR CASE INSTEAD OF MESSAGING CUSTOMER NOT ADDED,
                    //MESSAGE CREDITCARD NOT ADDED!
                    MessageBox.Show("Error! Credit Card was not added!");
                }
            }//End of try

            //Step B-Trap for BO, App & General Exceptions 
            catch (System.Exception)
            {
                //Step C- Prompt the user an error has occurred; 
                //IN OUR CASE INSTEAD OF MESSAGING ERROR IN REGISTRATION,
                //MESSAGE CREDITCARD!

                MessageBox.Show("Error! Credit Card was not added!");
            }
        }

        private void frmCreditCardRegistration_Load_1(object sender, EventArgs e)
        {
            //BINDING State ComboBox to the USState Class GetAllUSStates Static Method
            cbState.DataSource = USState.GetAllUSStates();
            //Set DisplayMember property to indicate which property gets displayed on the combobox
            //Set ValueMember Property to indicate which property to get data from in the code
            cbState.DisplayMember = "StateName";
            cbState.ValueMember = "StateCode"; //in this case we return the state code
                                           //BINDING Country ComboBox to the Country Class GetAllCountry Static Method
            cbCountry.DataSource = Country.GetAllCountries();
            //Set DisplayMember property to indicate which property gets displayed on the combobox
            //Set ValueMember Property to indicate which property is GOTTEN to used in the code
            cbCountry.DisplayMember = "CountryName";
            cbCountry.ValueMember = "CountryName"; //in this case we return the country name
                                               //Programmatically set the properties to the Activation Status Combo Box
                                               //and ADD the activated and deactivated items to the Combo Box
            cbActivationStatus.Items.Add("Activated");
            cbActivationStatus.Items.Add("Deactivate");
            //SET SELECTED TEXT Property to populate the ActivationStatus ComboBox to Activated
            cbActivationStatus.SelectedText = "Activated";
            //Other Code needed inside the Form_Loa()Event Handler
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbActivationStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
