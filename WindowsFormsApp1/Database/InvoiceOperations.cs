using System;
using System.Data;
using System.Data.SqlClient;

namespace Retalo
{

    public static class InvoiceOperations
    {
        public static Invoice ReturnInvoice(SqlCommand selectCommand, SqlConnection connect)
        {
            Invoice invoice = new Invoice();
            
            try{
                
                connect.Open();
                SqlDataReader invoiceReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (invoiceReader.Read())
                {
                    invoice.ID = (int)invoiceReader["InvID"];
                    invoice.PerID = (int)invoiceReader["PerID"];
                    invoice.DateOfInvoice = invoiceReader["DateOfInvoice"];
                    invoice.IsPaidFor = invoiceReader["Is Paid For"];
                    invoice.TotalCost = invoiceReader["Total Cost"];

                    invoice = PopulateProducts(invoice);
                    
                }

            }
            catch(Exception ex){

                throw ex;
                
            }
            finally{
                connect.Close();
            }
            
            return invoice;
            


        }

        private static Invoice PopulateProducts(Invoice invoice, SqlConnection connection){

            string invoicedetailsselect =
                "Select *"
                + " From \"Invoice Detail\""
                + " Where InvID = @id";

            return invoice;
            
            
        }

        
        public static Boolean AddInvoice(Invoice invoice)
        {
            /*   if(DatabaseOperation.ReturnItem(invoice) != null)
            {
                return false;
            }
            */
            return true;

        }
        
    }

}
