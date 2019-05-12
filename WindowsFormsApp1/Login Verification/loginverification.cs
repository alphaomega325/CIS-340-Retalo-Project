using System;

namespace Retalo
{

    public class loginverification {


        public boolean verify(String password, String email){

            if(password == "" || email == ""){

                return false;

            }

            Person person = DatabaseOperations.ReturnItem(email);

            if(person.Password == password){
                return true;
            }
            else{
                return false;
            }
            

    }

    }

}
