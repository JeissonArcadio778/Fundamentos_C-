using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double batery;

            Console.Write("Get the cargue of Batery: ");
            batery = Convert.ToInt32(Console.ReadLine());

            Console.Write("Get motor left avalue: ");
            bool motor_left = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Get motor right avalue: ");
            bool motors_right = Convert.ToBoolean(Console.ReadLine());


            if (batery >= 75)
            {
                if (motor_left || motors_right)
                {
                    Console.WriteLine("You can fly");
                }
                else
                {
                    Console.WriteLine("You can't fly");
                }

            }
            else if (batery <= 75 && batery >= 50)
            {
                if (motor_left && motors_right)
                {
                    Console.WriteLine("You can fly");
                }
                else
                {
                    Console.WriteLine("You can't fly");
                }
            }
            else
            {
                Console.WriteLine("You can't fly");
            }


            // Switch. Comparacion de posibles expresiones. 
            Console.Write("Give a color: ");
            string color = Console.ReadLine();

            switch (color)
            {
                case "Red":
                case "RED":
                case "red":
                    Console.WriteLine("Color RED");
                    break;
                case "Green":
                    Console.WriteLine("Color RED");
                    break;
                case "Blue":
                    Console.WriteLine("Color RED");
                    break;
                default:
                    Console.WriteLine("Is not correct");
                    break;
            }
        }
    }
}
