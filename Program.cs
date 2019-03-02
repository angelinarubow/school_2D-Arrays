using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //2D-Arrays
            string[,] personenTabelle = new string[3, 2];

            // Zeile 1
            personenTabelle[0, 0] = "Janek";
            personenTabelle[0, 1] = "21;";

            // Zeile 2
            personenTabelle[1, 0] = "Friedrich";
            personenTabelle[1, 1] = "20;";

            // Zeile 3
            personenTabelle[2, 0] = "Peter";
            personenTabelle[2, 1] = "10;";

            Console.WriteLine("Name:  " + personenTabelle[0, 0]);
            Console.WriteLine("Alter: " + personenTabelle[0, 1]);

            Console.ReadKey();
        }
    }
}
