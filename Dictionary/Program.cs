using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Dictionary: "key (unique) -value pair". As always.
            Dictionary<string, int> employees = new Dictionary<string, int>();

            //ADD: Key, Value
            employees.Add("Yeye", 22);
            employees.Add("Maria", 21);
            employees.Add("Valen", 24);

            //El retur de un forech de un dict es una estructura. Key, Value. [Key, Value]
            foreach (KeyValuePair<string, int> employee in employees)
            {
                Console.WriteLine("El empleado {0} tiene {1} años", employee.Key, employee.Value);
            }

            //Propiedad item. Manejo de las key para darle valores a sus values. 
            //Modify. 
            employees["Yeye"] = 23;

            employees["Misspopio"] = 15;

            //Get Item
            Console.WriteLine("Age Yeye: {0}", employees["Yeye"]);

            //Remove
            employees.Remove("Yeye"); //True

            //Determina si existe el elemento con la Key

            if (employees.ContainsKey("Yeye")) //ContainsValue. 
            {
                Console.WriteLine("Se encuenta");
            }
            else
            {
                Console.WriteLine("No se encuentra");
            }


        }
    }
}
