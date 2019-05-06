using System;
using System.Data;
using System.Data.SqlClient;

namespace Retalo
{

    public static class DatabaseOperation
    {

        protected static SqlCommand Return_Sql_Select_String(string database, string id, string idname, SqlConnection connect){


            string selectStatement
                = "Select *"
                + "FROM @database Where"
                + "@idname = @id";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connect); 

            selectCommand.Parameters.AddWithValue("@database", database);
            selectCommand.Parameters.AddWithValue("@id", id);
            selectCommand.Parameters.AddWithValue("@idname", idname);
            return selectCommand;

        }
        
        public static Person ReturnItem(Person person)
        {
            try{
                SqlConnection connect = RetaloDB.GetConnection();
                selectCommand = Return_Sql_Select_String("Person", person.ID, "PerID", connect);
                Person person2 = ReturnPerson(selectCommand, connect);
                return person2;
            }
            catch(Exception ex){
                throw ex;
            }
            
            return null;

            
        }

        public static Product ReturnItem(Product product)
        {
            try{
                SqlConnection connect = RetaloDB.GetConnection();
                selectCommand = Return_Sql_Select_String("Product", product.ID, "ProdID", connect);
                Product product2 = ReturnProduct(selectCommand, connect);
                return product2;
            }
            catch(Exception ex){
                throw ex;
            }
            
            return null;

            
        }

        
        public static Boolean DeleteItem(int id, String database){
            
            if (ReturnItem(id, database) == null)
            {
                return false;

            }
            else
            {

                SqlConnection connection = RetaloDB.GetConnection();
                string removestatement = "DELETE FROM @database WHERE @idname = @id";
                SqlCommand remove = new SqlCommand(removestatement, connection);
                remove.Parameters.AddWithValue("@id", id);
                remove.Parameters.AddWithValue("@database", database);
                if(database == "Person"){
                    remove.Parameters.AddWithValue("@idname", "PerID");        
                }
                else{
                    return false;
                }
                
                try
                {
                    connection.Open();
                    remove.ExecuteNonQuery();


                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                    
                }
                return true;
            }


        }

        public static Boolean AddorUpdateItem(Person person)
        {


            try
            {
                if (ReturnItem(person.ID, "Person") == null)
                {
                    return PersonOperations.AddPerson(person);

                }
                else
                {
                    return PersonOperations.UpdatePerson(person.ID, person);
                }
            }
            catch(Exception ex)
            {
                return false;
                throw ex;
            }
            

        }




        






    }
}
