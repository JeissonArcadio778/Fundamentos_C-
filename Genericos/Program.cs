using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Problema de las matrices: tamaño de datos. No hay flexibilidad.

            /*Colecciones: manipular grupos de objetos que están relacionados entre sí. Pueden crecer o dismunir su tamaño.
             * 
             * Genericas: seguras y modernas. Simplemente son otro tipo de variable. Son una plantilla de códigos. Son clases estructruras, interfaces y métodos que tiene parámetros de tipo, osea, en vez de pasar por cada tipo de estas, estas van simplemente en parametros como "Generic". 
             *  Tipos: 
             *  Diccionary, lits, Queu, SortedList. 
             * 
             *  Refencias integradas: refencias de .Net (bibliotecas internas) para referirse a cosas como String, Object
             * 
             * 
             * Tipo Object: tipo de refencia integrado. Una clase. Clase base fundamental. Todas las clases derivan de acá. Estos metodos de esta clase están disponibles, ejemplo, toString(). 
             */

            object numbInt = 14;

            object[] numbers = new object[2];

            numbers[0] = 1;
            numbers[1] = "Hello";

            //Pero no se pueden hacer operaciones. Solución: CASTEO. Cuidado con el tamaño de las variables.  

            //Conversión implicita. Para objetos se llama Boxing.
            byte numPequeño = 123;
            int numGrande = numPequeño;
            Console.WriteLine(numGrande);

            object cadena = 3;


            //(T)E -- casteo.
            numGrande = 500;
            numPequeño = (byte)numGrande;
            Console.WriteLine(numPequeño);


            //Unboxing
            object resultado = (int)cadena + 10;
            Console.WriteLine(resultado); //13

            //Para declarar un objeto de una clase generic, es necesario que sí especifiquemos el tipo de objeto que stamos creando: 
            TestGeneric<string> genericString = new TestGeneric<string>();

            TestGeneric<int> genericInt = new TestGeneric<int>();
        }

    }

    class TestGeneric<T>
    {
        //Clase generica: con eso le estamos diciendo que la clase TestGeneric, va a recibir parámetros de cualquier tipo. String, int o creado por nosotros mismos. 
    }

}


LISTAS:


using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic; 
namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Colecciones: flexibles. 

            //Como es una clase, debe ser instanciada.
            List<String> people = new List<String>();

            //ADD: lastIndex
            people.Add("Eulaloquita");
            people.Add("Eulajecutiva");
            people.Add("Eulabonita");
            people.Add("Eulabollito");

            int option;
            string person;
            do
            {
                Console.WriteLine("1. Agregare element in List<>");
                Console.WriteLine("0. Get Out.");
                option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    Console.Write("Person name: ");
                    person = Console.ReadLine();
                    people.Add(person);

                }

            } while (option != 0);

            //COUNT: contar los elementos. Is like length.             
            //for (int i = 0; i < people.Count; i++)
            //{
            //    Console.WriteLine(people[i]);
            //}



            //INSERT: inserta por index. (indice, elemento). Desplaza todo el resto de la lista. 

            people.Insert(0, "Islabel");

            //RemoveAt: elimina por index. (indice). Desplaza todo el resto
            people.RemoveAt(0);

            //IndexOf: encontrar index. 
            int index = people.IndexOf("Eulajecutiva");
            Console.WriteLine("index: {0}", index);

            //Clear: quita los elementos de la lista
            people.Clear(); //Esta presente en muchos elementos. 

            //FOR EACH. 
            foreach (string element in people)
            {
                Console.WriteLine("Element: {0}", element);
            }


        }
    }
}


Diccionarios:



