using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //++i, incluye el incremento en la misma linea de ejecución.
            //i++, incluye el incremento una linea después de la ejecución.

            //IS PRIME: 
            string isPrime;

            for (int i = 2; i <= 10; i++)
            {

                isPrime = "Prime";

                for (int j = 2; j < i; j++)
                {

                    if (i % j == 0)
                    {
                        isPrime = "Not Prime";
                    }

                }

                if (isPrime == "Prime")
                {
                    Console.WriteLine("NUMBER:::{0} is {1}", i, isPrime);
                }


            }



        }
    }
}
