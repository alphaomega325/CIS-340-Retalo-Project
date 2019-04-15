using System;

namespace Retalo
{

    public class Person : Item
    {

        private int reward_point;

        public String FName
        {
            get;
            set;
        }

        public String LName
        {
            get;
            set;
        }

        public String Phone_Number
        {
            get;
            set;
        }

        public String Email
        {
            get;
            set;
        }

        public Boolean IsAdmin
        {
            get;
            set;
        }

        public Boolean IsTeacher
        {
            get;
            set;
        }

        public Boolean IsVeteran
        {
            get;
            set;
        }

        public Boolean IsSenior
        {
            get;
            set;
        }

        public int Reward_Points
        {
            get
            {
                return reward_point;
            }
            private set
            {
                if (value < 0)
                {
                    throw new DataMisalignedException("Reward Points can't be set less than zero");
                }
                else
                {
                    reward_point = value;
                }
            }
        }

        public void set_Reward_Points(int reward) => Reward_Points = reward;
        
        public void add_Reward_Points(int reward) => Reward_Points += reward;
        
        public void subtract_Reward_Points(int reward) => Reward_Points -= reward;


    }

}
