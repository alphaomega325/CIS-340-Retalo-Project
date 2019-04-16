﻿using System;
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
                    int reward = 0;
                    Int32.TryParse(personReader["Reward Points"].ToString(), out reward);

                    person.Set_Reward_Points(reward);
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

	public static Boolean AddorUpdatePerson(Person person)
	{

	    if(ReturnPerson(person.ID) == null)
	    {
		return AddPerson(person);
	    }
	    else
	    {
		return UpdatePerson(person);
	    }


	}

	public static Boolean AddPerson(Person person)
	{

	    if(ReturnPerson(person.ID) != null)
	    {
		return false;

	    }
	    
	    SqlConnection connection = RetaloDB.GetConnection();
	    string addStatement = "INSERT INTO Person"
		+"Values(PerID = @ID, Fname = @FName, Lname = @LName, Phone Number = @Phone_Number, Email = @Email, Reward Points = @Reward Points, Is_Teacher = @IsTeacher, Is_Admin = @IsAdmin, Is_Senior = @IsSenior, Is_Veteran = @IsVeteran) ";
	    SqlCommand addCommand = new SqlCommand(addStatement, connection);
	    addCommand.Parameters.AddWithValue("@ID", person.ID);
	    addCommand.Parameters.AddWithValue("@FName", person.FName);
	    addCommand.Parameters.AddWithValue("@LName", person.LName);
	    addCommand.Parameters.AddWithValue("@Phone_Number", person.Phone_Number);
	    addCommand.Parameters.AddWithValue("@Email", person.Email);
	    addCommand.Parameters.AddWithValue("@Reward Points", person.Reward_Points);
	    addCommand.Parameters.AddWithValue("@IsTeacher", person.IsTeacher);
	    addCommand.Parameters.AddWithValue("@IsAdmin", person.IsAdmin);
	    addCommand.Parameters.AddWithValue("@IsSenior", person.IsSenior);
	    addCommand.Parameters.AddWithValue("@IsVeteran", person.IsVeteran);
	    try
	    {
		connection.Open();
		addCommand.ExecuteNonQuery();
		

	    }catch(Exception ex)
	    {
		throw ex;
	    }
	    finally
	    {
		connection.Close();

	    }
	    return true;

	    

	}

	public static Boolean UpdatePerson(Person person)
	{
	    if(ReturnPerson(person.ID) == null)
	    {
		return false;

	    }

	    SqlConnection connection = RetaloDB.GetConnection();
	    string updateStatement = "UPDATE Person"
		+"INTO Fname = @FName, Lname = @LName, Phone Number = @Phone_Number, Email = @Email, Reward Points = @Reward Points, Is_Teacher = @IsTeacher, Is_Admin = @IsAdmin, Is_Senior = @IsSenior, Is_Veteran = @IsVeteran "
		+"WHERE PerID = @ID";
	    SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

	    updateCommand.Parameters.AddWithValue("@ID", person.ID);
	    updateCommand.Parameters.AddWithValue("@FName", person.FName);
	    updateCommand.Parameters.AddWithValue("@LName", person.LName);
	    updateCommand.Parameters.AddWithValue("@Phone_Number", person.Phone_Number);
	    updateCommand.Parameters.AddWithValue("@Email", person.Email);
	    updateCommand.Parameters.AddWithValue("@Reward Points", person.Reward_Points);
	    updateCommand.Parameters.AddWithValue("@IsTeacher", person.IsTeacher);
	    updateCommand.Parameters.AddWithValue("@IsAdmin", person.IsAdmin);
	    updateCommand.Parameters.AddWithValue("@IsSenior", person.IsSenior);
	    updateCommand.Parameters.AddWithValue("@IsVeteran", person.IsVeteran);

	    try
	    {
		connection.Open();
		updateCommand.ExecuteNonQuery();

	    }catch(Exception ex)
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