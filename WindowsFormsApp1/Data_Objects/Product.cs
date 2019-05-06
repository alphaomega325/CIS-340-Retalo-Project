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

        public int ProductPurchasedQuantity{

            get;
            set;
            
        }

        public int GetProductPurchasedQuantity()
        {
           if(ProductPurchasedQuantity < 0)
            {
                ProductPurchasedQuantity = 0;
                return 0;
            }
            else
            {
                return ProductPurchasedQuantity;
            }
        }
            

        public void SetProductPurchasedQuantity(int quantity)
        {
            if(quantity < 0)
            {
                ProductPurchasedQuantity = 0;
            }
            else
            {
                ProductPurchasedQuantity = quantity;
            }
        }

    }

}
