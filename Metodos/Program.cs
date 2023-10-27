using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*
             * METHODS: 
             * instancia (creamos un objeto de esa clase) 
             * static (simplementa hacemos refencia a su nombre) 
             * 
             * [modificador] [tipo] [Indentificador] [parametros]
             * 
             * static void name(){}
             * 
             * Invocación: 
             * 
             */
          

            int option;

            //Tuple for returns:
            (decimal num1, decimal num2, decimal result) returnTuple;

            do
            {
                Console.WriteLine(" 1.SUM \n 2.REST \n 3.MULTIPLICATION \n 4.DIVISION");
                option = Convert.ToInt32(Console.ReadLine());

            } while (option < 1 || option > 4);

            switch (option)
            {

                case 1:
                    Console.WriteLine("SUM");
                    Sum();
                    break;

                case 2:
                    Console.WriteLine("REST");
                    returnTuple = Rest();
                    Console.WriteLine("The rest result is: {0}", returnTuple.result);
                    break;

                case 3:
                    Console.WriteLine("MULTIPLICATION");
                    decimal num1, num2;
                    num1 = InputNumber("Give the fist number: "); 
                    num2 = InputNumber("Give the second number: ");
                    Multiplication(num1, num2);
                    break;

                case 4:
                    Console.WriteLine("DIVITION");
                    num1 = InputNumber("Give the fist number: ");
                    num2 = InputNumber("Give the second number: ");
                    decimal result_div = Divition(num1, num2); 
                    Console.WriteLine("The div result is: {0}", result_div);
                    break;
            }

        }

        //Static para evitar hacer llamados mediantes instancias. 

        static decimal InputNumber(String input)
        {
            decimal number;

            Console.WriteLine(input);

            number = Convert.ToDecimal(Console.ReadLine());

            return number;

        }

        //void
        static void Sum()
        {
            decimal num1, num2, result;

            Console.Write("Give the fist number: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Give the second number: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            result = num1 + num2;

            Console.WriteLine("The sum result is: {0}", result);

        }

        //return type
        static (decimal, decimal, decimal) Rest()
        {
            decimal num1, num2, result;

            Console.Write("Give the fist number: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Give the second number: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            result = num1 - num2;

            //Return with Tuples: 
            return (num1, num2, result);


        }

        // Parametros
        static void Multiplication(decimal numberOne, decimal numberTwo)
        {
            decimal result;

            result = numberOne * numberTwo;

            Console.WriteLine("The multi result is: {0}", result);
        }

        static decimal Divition(decimal numberOne, decimal numberTwo)
        {
            decimal result = 0;

            if (numberTwo != 0)
            {
                result = numberOne / numberTwo;

            }
            else
            {
                Console.WriteLine("Is not possible do the divition of 0");
            }

            return result;

        }



    }
  
}
