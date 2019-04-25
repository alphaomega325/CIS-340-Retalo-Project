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
                Person person = ReturnPerson(selectCommand, connect);
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

        public static Boolean UpdateItem(int id, String database, Object item){
            if(ReturnItem(id, database) == null){
                return false;
            }

            if(database == "Person"){

                return UpdatePerson(item);

            }
            
                
                
            

        }

        public static Boolean UpdatePerson(Person person){



        }
        
        public static Person ReturnPerson(SqlCommand selectCommand, SqlConnection connect){

            Person person = new Person();
            try{
                
                connect.Open();
                SqlDataReader personReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (personReader.Read())
                {
                    person.ID = (int)personReader["PerID"];
                    person.FName = personReader["Fname"].ToString();
                    person.LName = personReader["Lname"].ToString();
                    person.Phone_Number = personReader["Phone Number"].ToString();
                    person.Email = personReader["Email"].ToString();
                    int reward = 0;
                    Int32.TryParse(personReader["Reward Points"].ToString(), out reward);

                    person.Set_Reward_Points(reward);
                    person.IsTeacher = (Boolean)personReader["Is_Teacher"];
                    person.IsAdmin = (Boolean)personReader["Is_Admin"];
                    person.IsSenior = (Boolean)personReader["Is_Senior"];
                    person.IsVeteran = (Boolean)personReader["Is_Veteran"];
                    person.Password = personReader["password"].ToString();
                    
                   
                }
                else
                {
                    person = null;
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connect.Close();
                
            }

            return person;
            

        }





        






    }
}
