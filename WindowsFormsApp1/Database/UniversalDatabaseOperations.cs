using System;
using System.Data;
using System.Data.SqlClient;

namespace Retalo
{

    public static class DatabaseOperation
    {
        
        public static Object ReturnItem(int id, String database)
        {
            
            SqlConnection connect = RetaloDB.GetConnection();
            string selectStatement
                = "Select *"
                + "FROM @database Where @idname = @id";
            
            SqlCommand selectCommand = new SqlCommand(selectStatement, connect); 
            selectCommand.Parameters.AddWithValue("@id", id);
            selectCommand.Parameters.AddWithValue("@database", database);
            if(database == "Person"){                
                selectCommand.Parameters.AddWithValue("@idname", "PerID");
                Person person = PersonOperations.ReturnPerson(selectCommand, connect);
                return person;
            }
            else{
                return null;
            }
            
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

        public static Boolean AddorUpdateItem<T>(int id, String database, ref T item) where T : Item
        {

            if(typeof(T) == typeof(Person)){

                Person person = (Person)item;
                if (ReturnItem(id, database) == null)
                {

                   
                    return PersonOperations.AddPerson(person);
                }
                else
                {
                    return PersonOperations.UpdatePerson(id, person);
                }
            }
            
            return false;
        }


        






    }
}
