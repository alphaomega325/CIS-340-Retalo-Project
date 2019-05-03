using System;

namespace Retalo
{

    public class Product : Item
    {

        private Decimal cost;

        public String Description{

            set;
            get;

        }

        public Decimal Cost{

            get{
                
                return cost;

            }

            set{
               
                cost = value;
            }

        }


        public String ProductType{

            get;
            set;

        }

        public int ProductQuantity{

            get;
            set;

        }

        public int ProductPurchasedQuantity{

            get;
            set;
            
        }

    }

}
