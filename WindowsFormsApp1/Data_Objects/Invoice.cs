using System;


namespace Retalo
{

    public class Invoice : Item
    {

        List<int> productininvoicequanity;
        int totalproductininvoicequantity;
        
        public int PerID{
            get;
            set;
        }


        public DateTime DateOfInvoice{

            get;
            set;

        }

        public binary IsPaidFor{
            get;
            set;
        }


        public int AmountofProducts{
            get{

                return ProductsInInvoice.length;

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
                foreach(ProductsInInvoice)
                {
                    totalproductininvoicequantity += ProductsInInvoice.ProductPurchasedQuantity;
                }
                return totalproductininvoicequantity;
            }
                
            set;

        }


        

    }


}
