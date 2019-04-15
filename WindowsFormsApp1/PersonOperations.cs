using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Retalo
{
    public static class PersonOperations
    {

        public static Person ReturnPerson(int id)
        {
            SqlConnection connect = RetaloDB.GetConnection();
            string selectStatement 
                = "SELECT *" 
                + "FROM Person WHERE PerID = @id";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connect);
            selectCommand.Parameters.AddWithValue("@id", id);

            try
            {
                connect.Open();
                SqlDataReader personReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (personReader.Read())
                {
                    Person person = new Person();
                    person.ID = (int)personReader["PerID"];
                    person.FName = personReader["Fname"].ToString();
                    person.LName = personReader["Lname"].ToString();
                    person.Phone_Number = personReader["Phone Number"].ToString();
                    person.Email = personReader["Email"].ToString();
                    person.set_Reward_Points((int)personReader["Reward Points"]);
                    person.IsTeacher = (Boolean)personReader["Is_Teacher"];
                    person.IsAdmin = (Boolean)personReader["Is_Admin"];
                    person.IsSenior = (Boolean)personReader["Is_Senior"];
                    person.IsVeteran = (Boolean)personReader["Is_Veteran"];

                    return person;
                }
                else
                {
                    return null;
                }


            }catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                connect.Close();
            }


        }

        public static Boolean DeletePerson(int id)
        {

            if (ReturnPerson(id) == null)
            {
                return false;

            }
            else
            {

                SqlConnection connection = RetaloDB.GetConnection();
                string removestatement = "DELETE FROM Person WHERE PerID = @id";
                SqlCommand remove = new SqlCommand(removestatement, connection);
                remove.Parameters.AddWithValue("@id", id);
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


    }
}
