using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMSDALayer;
using System.IO;

namespace ARMSBOLayer
{
    public class USState
    {
        #region "PUBLIC PROPERTIES DECLARATIONS"

        public int StateID { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }

        #endregion "PUBLIC PROPERTIES DECLARATIONS"

        public USState()
        {
            this.StateID = 0;
            this.StateCode = "";
            this.StateName = "";
        }

        public USState(int sID, string sCode, string sName)
        {
            this.StateID = sID;
            this.StateCode = sCode;
            this.StateName = sName;
        }



        ~USState()
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
                objPrinterFile.WriteLine("US State Information: ");
                objPrinterFile.WriteLine("US State ID = " + StateID);
                objPrinterFile.WriteLine("US State Code = " + StateCode);
                objPrinterFile.WriteLine("US State Name = " + StateName);

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

        public static List<USState> GetAllUSStates()
        {
            return DALayer_GetAllUSStates();
        }
        protected static List<USState> DALayer_GetAllUSStates()
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory to get the SQL Server FACTORY Data Access Object
                //using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-now that you have the SQL FACTORY object GET DAO object to do the work
                USStateDAO objUSStateDAO = objDAOFactory.GetUSStateDAO();

                //Step 3-call USStateDAO DAO to do the work & return COLLECTION of Data Transfer Objects
                List<USStateDTO> objUSStateDTOList = objUSStateDAO.GetAllRecords();


                //Step 4- test if List<USStateDTO> DTO collection exists 
                if (objUSStateDTOList != null)
                {

                    //Step 5-Create a LIST Collection of USState object to get copy of DTO collection
                    List<USState> objUSStateList = new List<USState>();

                    //Step 6-Loop through List<USStateDTO> objUSStateDTOList collection
                    foreach (USStateDTO objDTO in objUSStateDTOList)
                    {

                        //Step 6a-Create new USState object
                        USState objUSState = new USState();


                        //Step 6b-get the data from DTO object and SET USState object
                        objUSState.StateID = objDTO.StateID;
                        objUSState.StateCode = objDTO.StateCode;
                        objUSState.StateName = objDTO.StateName;


                        //Step 6c-Add USState Object to the objUSStateList List<USState> COLLECTION  
                        objUSStateList.Add(objUSState);

                    }//End of foreach

                    //Step 6d-once copy process ends, Return objUSStateList List<USState> COLLECTION
                    return objUSStateList;

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
                throw new Exception("Unexpected Error in DALayer_GetAllUSState(key) Method: {0} " + objE.Message);

            }
        }

    }
}
