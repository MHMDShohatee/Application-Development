using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMSDALayer;
using System.IO;

namespace ARMSBOLayer
{
    public class CreditCard
    {
        #region "CLASS PRIVATE DATA DECLARTIONS"
        /***************************************************
         Private INSTANCES & STATIC DATA Declartions
         **************************************************/
        private string m_CreditCardNumber;
        private string m_CreditCardOwnerName;
        private string m_CreditCardIssuingCompany;
        private int m_MerchantCode;
        private DateTime m_ExpDate;
        private string m_AddressLine1;
        private string m_AddressLine2;
        private string m_City;
        private string m_StateCode;
        private string m_ZipCode;
        private string m_Country;
        private decimal m_CreditCardLimit;
        private decimal m_CreditCardBalance;
        private bool m_ActivationStatus;

        #endregion "CLASS PRIVATE DATA DECLARATIONS"

        #region "CLASS PUBLIC PROPERTIES DECLARATIONS"
        /***************************************************
         Public INSTANCES & STATIC DATA Declartions
         **************************************************/
        public string CreditCardNumber
        {
            get { return m_CreditCardNumber; }
            set { m_CreditCardNumber = value; }
        }
        public string CreditCardOwnerName
        {
            get { return m_CreditCardOwnerName; }
            set { m_CreditCardOwnerName = value; }
        }
        public string CreditCardIssuingCompany
        {
            get { return m_CreditCardIssuingCompany; }
            set { m_CreditCardIssuingCompany = value; }
        }
        public int MerchantCode
        {
            get { return m_MerchantCode; }
            set { m_MerchantCode = value; }
        }
        public DateTime ExpDate
        {
            get { return m_ExpDate; }
            set { m_ExpDate = value; }
        }
        public string AddressLine1
        {
            get { return m_AddressLine1; }
            set { m_AddressLine1 = value; }
        }
        public string AddressLine2
        {
            get { return m_AddressLine2; }
            set { m_AddressLine2 = value; }
        }
        public string City
        {
            get { return m_City; }
            set { m_City = value; }
        }
        public string StateCode
        {
            get { return m_StateCode; }
            set { m_StateCode = value; }
        }
        public string ZipCode
        {
            get { return m_ZipCode; }
            set { m_ZipCode = value; }
        }
        public string Country
        {
            get { return m_Country; }
            set { m_Country = value; }
        }
        public decimal CreditCardLimit
        {
            get { return m_CreditCardLimit; }
            set { m_CreditCardLimit = value; }
        }
        public decimal CreditCardBalance
        {
            get { return m_CreditCardBalance; }
            set { m_CreditCardBalance = value; }
        }
        public bool ActivationStatus
        {
            get { return m_ActivationStatus; }
        }


        #endregion "CLASS PUBLIC PROPERTIES DECLARATIONS"

        #region "CONSTRUCTORS & DESTRUCTOR METHODS DECLARATIONS"
        /***************************************************
         Public DEFAULT CONSTRUCTORS Declartions

         **************************************************/
        public CreditCard()
        {
            m_CreditCardNumber = "";
            m_CreditCardOwnerName = "";
            m_CreditCardIssuingCompany = "";
            m_MerchantCode = 0;
            m_ExpDate = new DateTime().Date;
            m_AddressLine1 = "";
            m_AddressLine2 = "";
            m_City = "";
            m_StateCode = "";
            m_ZipCode = "";
            m_Country = "";
            m_CreditCardBalance = 3000.0M;
            m_CreditCardLimit = 3000.0M;
            m_ActivationStatus = true;
        }

        /***************************************************
         Public PARAMETERIZED CONSTRUCTORS Declartions
         **************************************************/
        public CreditCard(string ccName, string ccOwnerName, string ccICompany, int mCode, string eDate,
            string aLine1, string aLine2, string city, string sCode, string zCode,
            string cntry, decimal ccLimit = 3000.0M, decimal ccBalance = 3000.0M)
        {
            this.CreditCardNumber = ccName;
            this.CreditCardOwnerName = ccOwnerName;
            this.CreditCardIssuingCompany = ccICompany;
            this.MerchantCode = mCode;
            this.ExpDate = Convert.ToDateTime(eDate);
            this.AddressLine1 = aLine1;
            this.AddressLine2 = aLine2;
            this.City = city;
            this.StateCode = sCode;
            this.ZipCode = zCode;
            this.Country = cntry;
            this.CreditCardLimit = ccLimit;
            this.CreditCardBalance = ccBalance;

            m_ActivationStatus = true;
        }

        /***************************************************
         Public DECONSTRUCTOR Declartion
         **************************************************/
        ~CreditCard()
        {
            //no code required at this time.
        }

        #endregion "CONSTRUCTORS & DESTRUCTOR METHODS DECLARATAIONS"

        #region "PUBLIC INSTANCE & STATIC METHODS"
        /***************************************************
        Public INSTANCE METHODS Declartion
        ***************************************************/

        //*************************************************
        //Print() Method
        //Method that Prints the Credit Card data to Network_Printer.txt file

        public void Print()
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1- Create object to open or create Network_Printer.txt file for appending
                StreamWriter objPrinterFile = new StreamWriter("Network_Printer.txt", true);

                //Step 2-Write this object's data to file
                objPrinterFile.WriteLine("Credit Card Information: ");
                objPrinterFile.WriteLine("Credit Card Number = {0}", m_CreditCardNumber);
                objPrinterFile.WriteLine("Credit Card Owner Name = {0}", m_CreditCardOwnerName);
                objPrinterFile.WriteLine("Credit Card Issuing Company = {0}", CreditCardIssuingCompany);
                objPrinterFile.WriteLine("Merchant Code = {0}", m_MerchantCode);
                objPrinterFile.WriteLine("Expiration Date = {0}", m_ExpDate);
                objPrinterFile.WriteLine("AddressLine1 = {0}", m_AddressLine1);
                objPrinterFile.WriteLine("AddressLine2 = {0}", m_AddressLine2);
                objPrinterFile.WriteLine("City = {0}", m_City);
                objPrinterFile.WriteLine("State = {0}", m_StateCode);
                objPrinterFile.WriteLine("Zip code = {0}", m_ZipCode);
                objPrinterFile.WriteLine("Country = {0}", m_Country);
                objPrinterFile.WriteLine("Credit Card Limit = {0}", m_CreditCardLimit);
                objPrinterFile.WriteLine("Credit Card Balance = {0}", m_CreditCardBalance);
                objPrinterFile.WriteLine("Activation Status = {0}", m_ActivationStatus);

                objPrinterFile.WriteLine();
                objPrinterFile.WriteLine();

                //Step 3-Close file
                objPrinterFile.Close();

            } //End of try

            //Step B-Traps for general exception
            catch(Exception objE)
            {
                //Step C- Re-throw a general exception
                throw new Exception("Unexpected Error in Print() Method: {0}" + objE.Message);
            }

        }//End of method

        //*************************************************
        //Activate() Method
        //Method that activates the Credit Card by Setting the
        //////m_ActivationState data to TRUE.
        public bool Activate()
        {
            m_ActivationStatus = true;
            return m_ActivationStatus;
        }

        //*************************************************
        //Deactivate() Method
        //Method that deactivates the Credit Card by Setting the
        //////m_ActivationState data to FALSE.
        public bool Deactivate()
        {
            m_ActivationStatus = false;
            return m_ActivationStatus;
        }


        #endregion "PUBLIC INSTANCE & STATIC METHODS"


        #region "PUBLIC INSTANCE & STATIC DATA ACCESS METHODS"

        /***************************************************
        Public DATA ACCESS METHODS Declartion
        ***************************************************/

        //=================================================================
        //Name:         Load(key) Method
        //Purpose:      Public Data Access Method that starts the process
        //              of loading this object's data from database.
        //Algorithm:    Step 1-Calls PROTECTED DALayer_Load(keys) method to
        //              perform the data access by calling Data Access Layer
        //              services to do the work and querry the database
        //Parameter:    The STRING key or ID of the object to load.
        //Return Value: Boolean true if found and retrieved from database,
        //              false otherwise.

        public bool Load(String key)
        {
            //Starts the loading of this object's data from database
            return DALayer_Load(key);
        }

        //=================================================================
        //Name:         Insert() Method
        //Purpose:      Public Data Access Method that starts the inserting
        //              of this object's data to Credit Card database table.
        //Algorithm:    Step 1-Calls PROTECTED DALayer_Insert() method to
        //              perform the data access by calling Data Access Layer
        //              services to do the work and query the database
        //Parameter:    None
        //Return Value: Boolean true if success, false otherwise.
        public bool Insert()
        {
            //Starts the inserting of this object's data to Credit Card database table
            return DALayer_Insert();
        }

        //=================================================================
        //Name:         Update() Method
        //Purpose:      Public Data Access Method that starts the update
        //              of this object's data to database.
        //Algorithm:    Step 1-Calls PROTECTED DALayer_Update() method to
        //              perform the data access by calling Data Access Layer
        //              services to do the work and query the database
        //Parameter:    None
        //Return Value: Boolean true if success, false otherwise.
        public bool Update()
        {
            return DALayer_Update();
        }

        //=================================================================
        //Name:         Delete(key) Method
        //Purpose:      Public Data Access Method that starts the deleting
        //              of a record from database whose key is passed as
        //              parameter.
        //Algorithm:    Step 1-Calls PROTECTED DALayer_Delete(key) method to
        //              perform the data access by calling Data Access Layer
        //              services to do the work and delete the record from
        //              the database
        //Parameter:    The key or ID of the object to delete
        //Return Value: Boolean true if success, false otherwise.
        public bool Delete(String key)
        {
            //Starts the inserting of this object's data to Credit Card database table
            return DALayer_Delete(key);
        }

        //=================================================================
        //Name:         STATIC GetAllCreditCards() Method
        //Purpose:      Public Data Access Method that starts the
        //              fetching of all the creditcard records from the
        //              data to database.
        //Algorithm:    Step 1-Calls PROTECTED DALayer_GetAllCreditCards() 
        //              method to perform the data access by calling 
        //              Data Access Layer services to do the work and
        //              query the database and return a LIST COLLECTION
        //              of us all the CreditCards in the Credit Cards in
        //              the database table.
        //Parameter:    None
        //Return Value: LIST COLLECTION with all the CreditCard records.
        public static List<CreditCard> GetAllCreditCards()
        {
            return DALayer_GetAllCreditCards();
        }

        #endregion "PUBLIC INSTANCE & STATIC DATA ACCESS METHODS"


        #region "PROTECTED INSTANCE & STATIC DATA ACCESS METHODS"

        /***************************************************
        Public DATA ACCESS METHODS Declartion
        ***************************************************/

        //=================================================================
        //Name:         DALayer_Load(key) Method
        //Purpose:      Method that CALLS the Data Access Layer services
        //              to do the work and query the database.
        //Algorithm:    Calls the Data Access Layer to do the work       
        //Parameter:    The key or ID of the object to load.
        //Return Value: Boolean true if found and retrieved from database, false
        //              otherwise.
        protected bool DALayer_Load(string key)
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory to get the SQL Server FACTORY Data Access Object
                //using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-now that you have the sql FACTORY data access object 
                //call the correct Data Access Object to perform the Data Access
                CreditCardDAO objCreditCardDAO = objDAOFactory.GetCreditCardDAO();

                //Step 3-Call DATA ACCESS LAYER CreditCardDAO Data Access Object to do the work
                CreditCardDTO objCreditCardDTO = objCreditCardDAO.GetRecordByID(key);

                //Step 4- test if DTO object exists & populate this object with DTO object's properties
                //and return a true or return a False if no DTO object exists.
                if (objCreditCardDTO != null)
                {
                    //Step 4a-get the data from the Data Transfer Object
                    this.CreditCardNumber = objCreditCardDTO.CreditCardNumber;
                    this.CreditCardOwnerName = objCreditCardDTO.CreditCardOwnerName;
                    this.CreditCardIssuingCompany = objCreditCardDTO.CreditCardIssuingCompany;
                    this.MerchantCode = objCreditCardDTO.MerchantCode;
                    this.ExpDate = objCreditCardDTO.ExpDate;
                    this.AddressLine1 = objCreditCardDTO.AddressLine1;
                    this.AddressLine2 = objCreditCardDTO.AddressLine2;
                    this.City = objCreditCardDTO.City;
                    this.StateCode = objCreditCardDTO.StateCode;
                    this.ZipCode = objCreditCardDTO.ZipCode;
                    this.Country = objCreditCardDTO.Country;
                    this.CreditCardLimit = objCreditCardDTO.CreditCardLimit;
                    this.CreditCardBalance = objCreditCardDTO.CreditCardBalance;

                    //Handle activation status accordingly using methods
                    //since ActivationStutus property is read only
                    if (objCreditCardDTO.ActivationStatus == true)
                        this.Activate();
                    else
                        this.Deactivate();

                    //Step 4c-Returns a true since this class object has been populated.
                    return true;
                }
                else
                {
                    //Step 5- No object returned from DALayer, return a false
                    return false;
                }

            }//End of try
             //Step B-Traps for general exception.  
            catch (Exception objE)
            {
                //Step C-Re-Throw an general exceptions
                throw new Exception("Unexpected Error in DALayer_Load(key) Method: {0} " + objE.Message);
            }
        }//End of method


        //=================================================================
        //Name:         DALayer_Insert(key) Method
        //Purpose:      Method that CALLS the Data Access Layer services
        //              to do the work of INSERTING record to the database.
        //Algorithm:    Calls the Data Access Layer to do the work       
        //Parameter:    None.
        //Return Value: Boolean true if record inserted, false otherwise.

        protected bool DALayer_Insert()
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory to get the SQL Server FACTORY Data Access Object
                //using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-now that you have the sql FACTORY data access object 
                //call the correct Data Access Object to perform the Data Access
                CreditCardDAO objCreditCardDAO = objDAOFactory.GetCreditCardDAO();

                //Step 3-Create new Data Transfer Object to send to DA Later for DATA ACCESS LAYER
                CreditCardDTO objCreditCardDTO = new CreditCardDTO();

                //Step 4- POPULATE the Data Transfer Object with data from THIS OBJECT to send to database
                objCreditCardDTO.CreditCardNumber = this.CreditCardNumber;
                objCreditCardDTO.CreditCardOwnerName = this.CreditCardOwnerName;
                objCreditCardDTO.CreditCardIssuingCompany = this.CreditCardIssuingCompany;
                objCreditCardDTO.MerchantCode = this.MerchantCode;
                objCreditCardDTO.ExpDate = this.ExpDate;
                objCreditCardDTO.AddressLine1 = this.AddressLine1;
                objCreditCardDTO.AddressLine2 = this.AddressLine2;
                objCreditCardDTO.City = this.City;
                objCreditCardDTO.StateCode = this.StateCode;
                objCreditCardDTO.ZipCode = this.ZipCode;
                objCreditCardDTO.Country = this.Country;
                objCreditCardDTO.CreditCardLimit = this.CreditCardLimit;
                objCreditCardDTO.CreditCardBalance = this.CreditCardBalance;
                objCreditCardDTO.ActivationStatus = this.ActivationStatus;

                //Step 5-Call DATA ACCESS LAYER CreditCardDAO Data Access Object to do the work
                bool inserted = objCreditCardDAO.Insert(objCreditCardDTO);

                //Step 6- test if insert to database was successful return true,
                //otherwise return false
                if (inserted == true)
                {

                    //Step 6b-Returns a true since this class object has been inserted & marked as old.
                    return true;
                }
                else
                {
                    //Step 7- No record inserted, return a false
                    return false;
                }

            }//End of try
             //Step B-Traps for general exception.  
            catch (Exception objE)
            {
                //Step C-Re-Throw an general exceptions
                throw new Exception("Unexpected Error in DALayer_Insert() Method: {0} " + objE.Message);
            }

        }//End of method

        //=================================================================
        //Name:         DALayer_Update() Method
        //Purpose:      Method that CALLS the Data Access Layer services to
        //              do the work of UPDATING record to the database.
        //Algorithm:    Calls the Data Access Layer to do the work.
        //Parameter:    None.
        //Return Value: Boolean true if record updated, false otherwise.

        protected bool DALayer_Update()
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory to get the SQL Server FACTORY Data Access Object
                //using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-now that you have the sql FACTORY data access object 
                //call the correct Data Access Object to perform the Data Access
                CreditCardDAO objCreditCardDAO = objDAOFactory.GetCreditCardDAO();

                //Step 3-Create new Data Transfer Object to send to DA Later for DATA ACCESS LAYER
                CreditCardDTO objCreditCardDTO = new CreditCardDTO();

                //Step 4- POPULATE the Data Transfer Object with data from THIS OBJECT to send to database
                objCreditCardDTO.CreditCardNumber = this.CreditCardNumber;
                objCreditCardDTO.CreditCardOwnerName = this.CreditCardOwnerName;
                objCreditCardDTO.CreditCardIssuingCompany = this.CreditCardIssuingCompany;
                objCreditCardDTO.MerchantCode = this.MerchantCode;
                objCreditCardDTO.ExpDate = this.ExpDate;
                objCreditCardDTO.AddressLine1 = this.AddressLine1;
                objCreditCardDTO.AddressLine2 = this.AddressLine2;
                objCreditCardDTO.City = this.City;
                objCreditCardDTO.StateCode = this.StateCode;
                objCreditCardDTO.ZipCode = this.ZipCode;
                objCreditCardDTO.Country = this.Country;
                objCreditCardDTO.CreditCardLimit = this.CreditCardLimit;
                objCreditCardDTO.CreditCardBalance = this.CreditCardBalance;
                objCreditCardDTO.ActivationStatus = this.ActivationStatus;


                //Step 5-Call DATA ACCESS LAYER CreditCardDAO Data Access Object to do the work
                bool updated = objCreditCardDAO.Update(objCreditCardDTO);

                //Step 6- test if update to database was successful & MARK the object as old return true,
                //otherwise return false
                if (updated == true)
                {
                    //Step 6b-Returns a true since this class object has been updated.
                    return true;
                }
                else
                {
                    //Step 7- No record updated, return a false
                    return false;
                }
            }//End of try
             //Step B-Traps for general exception.  
            catch (Exception objE)
            {
                //Step C-Re-Throw an general exceptions
                throw new Exception("Unexpected Error in DALayer_Update() Method: {0} " + objE.Message);
            }
        }//End of method

        //=================================================================
        //Name:         DALayer_Delete() Method
        //Purpose:      Method that CALLS the Data Access Layer services to
        //              do the work of DELETING record to the database.
        //Algorithm:    Calls the Data Access Layer to do the work.
        //Parameter:    Key or ID of record in database.
        //Return Value: Boolean true if record deleted, false otherwise.

        protected bool DALayer_Delete(string key)
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory to get the SQL Server FACTORY Data Access Object
                //using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-now that you have the sql FACTORY data access object 
                //call the correct Data Access Object to perform the Data Access
                CreditCardDAO objCreditCardDAO = objDAOFactory.GetCreditCardDAO();

                //Step 3-Call DATA ACCESS LAYER CreditCardDAO Data Access Object to do the work
                bool deleted = objCreditCardDAO.Delete(key);


                //Step 4- Test if delete to database was successful & MARK the object as NEW since
                //deleted from database and NEW in memory and return a true, otherwise return false
                if (deleted == true)
                {
                    //Step 4b-Returns a true since this class object has been deleted & marked as NEW.
                    return true;
                }
                else
                {
                    //Step 5-No record deleted, return a false
                    return false;
                }

            }//End of try
             //Step B-Traps for general exception.  
            catch (Exception objE)
            {
                //Step C-Re-Throw an general exceptions
                throw new Exception("Unexpected Error in DALayer_Update() Method: {0} " + objE.Message);
            }

        }//End of method

        //=================================================================
        //Name:         DALayer_GetAllCreditCards() Method
        //Purpose:      Method that CALLS the Data Access Layer services to
        //              do the work and query the database and return a
        //              LIST COLLECTION with all the CreditCard records data
        //              via a light-weight DATA TRANSFER OBJECTS(DTO).
        //Algorithm:    Calls the Data Access Layer to do the work.
        //Parameter:    None.
        //Return Value: A LIST COLLECTION containing Data Transfer Objects. Each DTO contain
        //              a row from the customer table.
        protected static List<CreditCard> DALayer_GetAllCreditCards()
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory to get the SQL Server FACTORY Data Access Object
                //using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-now that you have the SQL FACTORY object GET DAO object to do the work
                CreditCardDAO objCreditCardDAO = objDAOFactory.GetCreditCardDAO();

                //Step 3-call CreditCardDAO DAO to do the work & return COLLECTION of Data Transfer Objects
                List<CreditCardDTO> objCreditCardDTOList = objCreditCardDAO.GetAllRecords();


                //Step 4- test if List<CreditCardDTO> DTO collection exists 
                if (objCreditCardDTOList != null)
                {

                    //Step 5-Create a LIST Collection of CreditCard object to get copy of DTO collection
                    List<CreditCard> objCreditCardList = new List<CreditCard>();

                    //Step 6-Loop through List<CreditCardDTO> objCreditCardDTOList collection
                    foreach (CreditCardDTO objDTO in objCreditCardDTOList)
                    {

                        //Step 6a-Create new CreditCard object
                        CreditCard objCreditCard = new CreditCard();


                        //Step 6b-get the data from DTO object and SET CreditCard object
                        objCreditCard.CreditCardNumber = objDTO.CreditCardNumber;
                        objCreditCard.CreditCardOwnerName = objDTO.CreditCardOwnerName;
                        objCreditCard.CreditCardIssuingCompany = objDTO.CreditCardIssuingCompany;
                        objCreditCard.MerchantCode = objDTO.MerchantCode;
                        objCreditCard.ExpDate = objDTO.ExpDate;
                        objCreditCard.AddressLine1 = objDTO.AddressLine1;
                        objCreditCard.AddressLine2 = objDTO.AddressLine2;
                        objCreditCard.City = objDTO.City;
                        objCreditCard.StateCode = objDTO.StateCode;
                        objCreditCard.ZipCode = objDTO.ZipCode;
                        objCreditCard.Country = objDTO.Country;
                        objCreditCard.CreditCardLimit = objDTO.CreditCardLimit;
                        objCreditCard.CreditCardBalance = objDTO.CreditCardBalance;

                        //Handle activation status accordingly since ActivationStutus property is read only
                        if (objDTO.ActivationStatus == true)
                            objCreditCard.Activate();
                        else
                            objCreditCard.Deactivate();

                        //Step 6c-Add CreditCard Object to the objCreditCardList List<CreditCard> COLLECTION  
                        objCreditCardList.Add(objCreditCard);

                    }//End of foreach

                    //Step 6d-once copy process ends, Return objCreditCardList List<CreditCard> COLLECTION
                    return objCreditCardList;

                }//End of if


                else
                {
                    //Step 6e- No DTO collection object returned from DALayer, return a null
                    return null;
                }

            }//End of try

            //Step B-Traps for general exception.  
            catch (Exception objE)
            {
                //Step C-Re-Throw a general exceptions
                throw new Exception("Unexpected Error in DALayer_GetAllCreditCards(key) Method: {0} " + objE.Message);
            }
        }//End of method

        #endregion "PROTECTED INSTANCE & STATIC DATA ACCESS METHODS"

    }
}
