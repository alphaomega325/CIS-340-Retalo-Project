using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

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
                    invoice.DateOfInvoice = (DateTime)invoiceReader["DateOfInvoice"];
                    invoice.IsPaidFor = (bool)invoiceReader["Is Paid For"];
                    invoice.TotalCost = (decimal)invoiceReader["Total Cost"];

                    invoice = PopulateProducts(invoice, connect);
                    
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

            SqlCommand invoicedetailsselectcommand = new SqlCommand(invoicedetailsselect, connection);

            invoicedetailsselectcommand.Parameters.AddWithValue("@id", invoice.ID);

            try
            {
                connection.Open();
                SqlDataReader productreader = invoicedetailsselectcommand.ExecuteReader(CommandBehavior.SingleRow);
                List<Product> products = new List<Product>();
                

                while(productreader.Read())
                {
                    Product tempproduct = new Product();
                    tempproduct.ID = (int)productreader["ProdID"];
                    tempproduct = DatabaseOperation.ReturnItem(tempproduct);
                    tempproduct.SetProductPurchasedQuantity((int)productreader["Quantity"]);
                    products.Add(tempproduct);

                }

                invoice.ProductsInInvoice = products;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
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
