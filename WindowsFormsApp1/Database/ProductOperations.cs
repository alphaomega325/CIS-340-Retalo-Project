using System;
using System.Data;
using System.Data.SqlClient;

namespace Retalo{

    public static class ProductOperations
    {

        public static Product ReturnProduct(SqlCommand selectCommand, SqlConnection connect)
        {
            Product product = new Product();

            try{

                connect.Open();
                SqlDataReader productReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);





            }
            catch(Exception ex){

                throw ex;
                
            }
            finally{
                connect.Close();
            }


            return product;
            


        }
        



    }

    


}
