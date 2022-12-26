using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ARMSDALayer
{
    public class USStateDAO : IUserInterfaceDAO<USStateDTO>
    {
        public List<USStateDTO> GetAllRecords()
        {
            //Step 1-GET the Connection from SQLServerDAOFactory Object & Create ADO SqlConnection Object
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());
            try
            {
                //Step 2-Open connection
                objConn.Open();
                //Step 3-Create SQL string
                string strSQL = "SELECT * FROM USSTATE;";

                //Step 4-Create Command object, pass query and connection object
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);
                //Step 5-SET CommandType Property to text since we have a query string & NOT a Stored-Procedure
                //For stored procedures syntax is objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandType = CommandType.Text;
                //Step 6-Create DATAREADER POINTER & Execute Query via
                //COMMAND OBJECT ExecuteReader Method which returns a populated
                //DATAREADER OBJECT with the results of the query
                SqlDataReader objDR = objCmd.ExecuteReader();
                //Step 7
                if (objDR.HasRows)
                {

                    List<USStateDTO> colRecordList = new List<USStateDTO>();



                    while (objDR.Read())
                    {
                        USStateDTO objDTO = new USStateDTO();

                        objDTO.StateID = objDR.GetByte(0);
                        objDTO.StateCode = objDR.GetString(1);
                        objDTO.StateName = objDR.GetString(2);

                        colRecordList.Add(objDTO);
                    }//End of loop
                return colRecordList;
                }
                else
                {
                    objDR.Close();
                    objDR = null;
                    objCmd.Dispose();
                    objCmd = null;
                    return null;
                }//End of if/else
            }//End of try
             //Step B-Trap for BO, App & General Exceptions
            catch (Exception objE)
            {
                throw new Exception("Unexpected Error in USStatesDAO GetAllRecords() Method: {0} " + objE.Message);
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }
        }//End of GetAllRecords
    }
}
