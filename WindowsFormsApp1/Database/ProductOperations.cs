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
                if (productReader.Read())
                {

                    product.ID = (int)productReader["ProdID"];
                    product.Name =  productReader["Name"].ToString();
                    product.Cost =  (decimal)productReader["Cost"]
                    product.ProductType =  productReader["Product Type"].ToString();
                    product.Description =  productReader["Description"].ToString();


                }




            }
            catch(Exception ex){

                throw ex;
                
            }
            finally{
                connect.Close();
            }


            return product;
            


        }
        
        public static Boolean AddProduct(Product product)
        {





        }


    }

    


}
