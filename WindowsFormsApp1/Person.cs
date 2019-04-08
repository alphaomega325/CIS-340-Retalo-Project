using System;

namespace Retalo
{

    public class Person : Item
    {

        private int reward_point;

        public Boolean IsTeacher {
	        get;
	    }

	    public Boolean IsVeteran {
	        get;
	    }

	    public Boolean IsSeniorCitizen {
	        get;
	    }

	    public int Reward_Point {
	        get
	        {
		    return reward_point;
	        }
	        private set
	        {
		    if(value < 0)
		    {
			throw new NumberUnderflowException();
		    }
	        }
	    }



    }

}
