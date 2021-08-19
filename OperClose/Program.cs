using System;

namespace OpenClose
{
    class Program
    {
        static void Main(string[] args)
        {
            //classOpenClose c = new classOpenClose(); Old virsion 
            //c.Id = 1;
            //c.Product = "T-shirt";
            //c.Price = 5;

            //Console.WriteLine(c.ToString() +
            //                  Environment.NewLine+
            //                  c.TotalPrice(2));

            /* CONSTRUCTUR METHOD
            productNoVAT pn = new productNoVAT();
            pn.Id = 1;
            pn.Price = 3;
            pn.Product = "Dress";
            Console.WriteLine(pn.ToString()+
                              Environment.NewLine+
                              pn.TotalPrice(1));


            productWithVAT pw = new productWithVAT();
            pw.Id = 1;
            pw.Price = 3;
            pw.Product = "Dress";
            Console.WriteLine(pw.ToString() +
                              Environment.NewLine +
                              pw.TotalPrice(1));*/

            /*INTERFACE METHOD*/
            productNoVATi pn = new productNoVATi();
            pn.Id = 1;
            pn.Price = 3;
            pn.Product = "Dress";
            Console.WriteLine(pn.ToString() +
                              Environment.NewLine +
                              pn.Totalprice(1));


            productWithVATi pw = new productWithVATi();
            pw.Id = 1;
            pw.Price = 3;
            pw.Product = "Dress";
            Console.WriteLine(pw.ToString() +
                              Environment.NewLine +
                              pw.Totalprice(1));

        }
    }
}
