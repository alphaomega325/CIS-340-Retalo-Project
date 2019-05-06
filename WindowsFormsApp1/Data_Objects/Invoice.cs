using System;
using System.Collections.Generic;


namespace Retalo
{

    public class Invoice : Item
    {

        List<int> productininvoicequanity = new List<int>();
        int totalproductininvoicequantity;
        
        public int PerID{
            get;
            set;
        }


        public DateTime DateOfInvoice{

            get;
            set;

        }

        public Boolean IsPaidFor{
            get;
            set;
        }


        public int AmountofProducts{
            get{

                return ProductsInInvoice.Count;

            }
        }
        
        public Decimal TotalCost{

            get;
            set;

        }

        
        
        public List<Product> ProductsInInvoice{

            get;
            set;

        }

        public int TotalProductInInvoiceQuantity{

            get{

                totalproductininvoicequantity = 0;
                foreach(Product products in ProductsInInvoice)
                {
                    totalproductininvoicequantity += products.GetProductPurchasedQuantity();
                }
                return totalproductininvoicequantity;
            }

               

        }


        

    }


}
