using System;
using system.Collections.Generic;

namespace Retalo
{

    public class CalculateInvoiceTotal {

        public Invoice CalculateInvoiceTotal(Person customer, Invoice invoice, Boolean useRewards){

            
            foreach(Product products in invoice.ProductInInvoice){

                if((products.ProductType == "Books") && (customer.IsTeacher == true)){
                    
                    invoice.TotalCost += products.TotalProductPurchasedCost - (products.TotalProductPurchasedCost * .1);
                    

                }

                invoice.TotalCost += products.TotalProductPurchasedCost;
                

            }

            if((customer.IsSenior == false) || (customer.IsVeteran == false)){

                invoice.TotalCost += invoice.TotalCost * .55;

            }
            else if((customer.IsVeteran) && (customer.IsSenior)){

                invoice.TotalCost -= invoice.TotalCost * .15;
                
            }
            else if(customer.IsVeteran){

                invoice.TotalCost -= invoice.TotalCost * .10;
                
            }
            else if(customer.IsSenior){

                invoice.TotalCost -= invoice.TotalCost * .5;
                
            }
            
            
            while((useRewards == true) && (customer.Reward_Points >= 100)){

                invoice.TotalCost -= 5;
                customer.Subtract_Reward_Points(100);
                    
            }

            if((invoice.TotalCost >= 50)){
                
                customer.Add_Reward_Points(invoice.TotalCost);
            }
            
            return Invoice;

        }

        public Invoice CalculateEstimatedInvoiceWithoutBonus(Invoice invoice)
        {
            
            foreach(Product products in invoice.ProductInInvoice){
                       
                invoice.TotalCost += products.TotalProductPurchasedCost;
            }

            invoice.TotalCost += invoice.TotalCost * .55;

            return invoice;
            
        }
            
    }


}
