using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMSDALayer;
using System.IO;

namespace ARMSBOLayer
{
    public class Country
    {
        public int CountryID { get; set; }
        public string CountryCode2Char { get; set; }
        public string CountryCode3Char { get; set; }
        public string CountryName { get; set; }

        public Country()
        {
            this.CountryID = 0;
            this.CountryCode2Char = "";
            this.CountryCode3Char = "";
            this.CountryName = "";
        }

        public Country(int cID, string cC2, string cC3, string cName)
        {
            this.CountryID = cID;
            this.CountryCode2Char = cC2;
            this.CountryCode3Char = cC3;
            this.CountryName = cName;
        }

        ~Country()
        {
            //No code required at the time
        }
        public void Print()
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1- Create object to open or create Network_Printer.txt file for appending
                StreamWriter objPrinterFile = new StreamWriter("Network_Printer.txt", true);

                //Step 2-Write this object's data to file
                objPrinterFile.WriteLine("Country Information: ");
                objPrinterFile.WriteLine("Country ID = " + CountryID);
                objPrinterFile.WriteLine("Country Code 2 Characters = " + CountryCode2Char);
                objPrinterFile.WriteLine("Country Code 3 Characters = " + CountryCode3Char);
                objPrinterFile.WriteLine("Country Name = " + CountryName);

                objPrinterFile.WriteLine();
                objPrinterFile.WriteLine();

                //Step 3-Close file
                objPrinterFile.Close();

            } //End of try

            //Step B-Traps for general exception
            catch (Exception objE)
            {
                //Step C- Re-throw a general exception
                throw new Exception("Unexpected Error in Print() Method: {0}" + objE.Message);
            }
        }//End of method

        public static List<Country> GetAllCountries()
        {
            return DALayer_GetAllCountries();
        }
        protected static List<Country> DALayer_GetAllCountries()
        {
            //Step A-Start for Error Trapping
            try
            {
                //Step 1-Use DAL Object Factory to get the SQL Server FACTORY Data Access Object
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-Now that you have the SQL FACTORY object GET DAO object to do the work
                CountryDAO objCountryDAO = objDAOFactory.GetCountryDAO();

                //Step 3-Call USStateDAO to do the work * return COLLECTION of Data Transfer Objects
                List<CountryDTO> objCountryDTOList = objCountryDAO.GetAllRecords();

                //Step 4-Test if List<objDTO> DTO collection exists
                if (objCountryDTOList != null)
                {
                    //Step 5-Create a LIST Collection of USStates object to get copy of DTO collection
                    List<Country> objCountryList = new List<Country>();

                    //Step 6-Loop through List<CountryDTO> objUSStatesDTOList collection
                    foreach (CountryDTO objDTO in objCountryDTOList)
                    {
                        //Step 6a-Create new CreditCard object
                        Country objCountry = new Country();
                        //Step 6b-get the data from DTO object and SET CreditCard object
                        objCountry.CountryID = objDTO.CountryID;
                        objCountry.CountryCode2Char = objDTO.CountryCode2Char;
                        objCountry.CountryCode3Char = objDTO.CountryCode3Char;
                        objCountry.CountryName = objDTO.CountryName;

                        //Step 6c- Add CreditCard Object to the objCreditCardList List<CreditCard> COLLECTION
                        objCountryList.Add(objCountry);
                    }//End of foreach
                    //Step 6d- once copy process ends, Return objCreditCardList List<CreditCard> COLLECTION
                    return objCountryList;
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
                throw new Exception("Unexpected Error in DALayer_GetAllCountries() Method: {0} " + objE.Message);
            }
        }
    }
}
