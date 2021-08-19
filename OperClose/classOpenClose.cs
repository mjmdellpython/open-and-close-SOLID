using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClose
{
    /*To make any change of pruducts we will need to change the main class 'classOpenClose'
         , so to save it form any possible futre changes we should follow the oper / close
         principle with SOLID
        
         There are two possible ways to make it
        - Using abstract class
        - Using interface
        
         */
    public abstract class classOpenClose // Add abstract when using abstract way
    {
        
        public int Id { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }


        public abstract decimal TotalPrice(int Vat); // and add abstract to maintain method and
                                                     // delete the implement in method.
        

        public override string ToString()
        {
            return $"The order {Id} for product {Product}";
        }
    }


    class productNoVAT : classOpenClose
    {
        public override decimal TotalPrice(int Vat)
        {
            {
                
                 return Price;
                
            }
        }
    }

    class productWithVAT : classOpenClose
    {
        public override decimal TotalPrice(int Vat)
        {
            if (Price > 2)
            {
                return Price + Vat;
            }
            else
                return Price;
        }
    }

    /*when Using interface atteibute we should create interface contain the method that we will need
     to implement the possible changes*/

    interface Iproduct
    {
        decimal Totalprice(int VAT);
    }

    class productNoVATi : Iproduct
    {

        public int Id { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Totalprice(int VAT)
        {
            return Price;
        }
        public override string ToString()
        {
            return $"The order {Id} for product {Product}";
        }
    }

    class productWithVATi : Iproduct
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Totalprice(int VAT)
        {
            if (Price > 2)
            {
                return Price + VAT;
            }
            else
                return Price;
        }
        public override string ToString()
        {
            return $"The order {Id} for product {Product}";
        }
    }

} 