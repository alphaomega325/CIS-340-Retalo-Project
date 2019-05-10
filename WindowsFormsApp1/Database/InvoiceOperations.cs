using System;
using System.Data;
using System.Data.SqlClient;

namespace Retalo
{

    public static class InvoiceOperations
    {
        public static Invoice ReturnInvoice(SqlCommand selectComman, SqlConnection connect)
        {
            Invoice invoice = new Invoice();
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
