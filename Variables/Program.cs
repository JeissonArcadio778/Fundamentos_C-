using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World with Write-salto");
            Console.Write("Hello World with Write-sin-salto");


            //Constantes
            const string nacionalidad = "Colombiana";
            const string amores = "Loquita";

            //Variables
            int dinero = 0;
            char salon = 'A';

            
            //Obligatory
            float averageStudents = 8.0f;
            decimal averageProfessors = 9.9m;


            Console.WriteLine("The price of the Shirt is: {0} and his color is: {1}", dinero, salon);

            //Using Division:

            Console.WriteLine(10f / 3f); //3.333333

            //Inputs

            double h, b, l, a, p;

            Console.Write("Give me 'h', please: ");
            h = Convert.ToDouble(Console.ReadLine());


        }
    }
}
