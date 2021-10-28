namespace ProgressTaskThree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        // Was not able to do a .trdx/.trdp report sample with inline CSV data. Didn't found information on how to do it.
        static List<string> Products = new List<string> { "Blade", "Chain", "Chainring", "Decal", "Decal", "Down", "Tube", "Fube End", "Freewheel", "Head Tube", "Hex Nut", "HL Fork", "Hl Hub", "HL Nipple"
                , "LL Shell", "Lock", "Ring", "Minipump", "ML Fork", "Reflector", "Seat Lug", "Seat Post", "Seat Tube", "Spokes", "Steerer", "Sterm", "Top Tube"};

        static void Main(string[] args)
        {           
            Console.WriteLine(ReturnProducts(Products));
        }

        private static string ReturnProducts(List<string> products)
        {
             return string.Join(", ", products.Where(x => x.Length < 7).Distinct());            
        }
    }
}
