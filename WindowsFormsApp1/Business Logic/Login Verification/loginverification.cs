using System;

namespace Retalo
{

    public class loginverification {


        public Boolean verify(String password, String email){

            if(password == "" || email == ""){

                return false;

            }

            Person person = DatabaseOperation.ReturnItem(email);

            if(person.Password == password){
                return true;
            }
            else{
                return false;
            }
            

    }

    }

}
