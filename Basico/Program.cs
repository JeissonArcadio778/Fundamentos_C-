using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Hacer un programa que imprima en pantalla el mensaje "Hola, mundo!".

Hacer un programa que pida al usuario dos números y los sume.

Hacer un programa que pida al usuario su nombre y lo salude.

Hacer un programa que pida al usuario un número entero y determine si es par o impar.

Hacer un programa que pida al usuario un número entero y determine si es primo o no.

Hacer un programa que pida al usuario un número entero y calcule su factorial.

Hacer un programa que pida al usuario un número entero y determine si es positivo, negativo o cero.

Hacer un programa que pida al usuario una cadena de texto y determine si es un palíndromo o no.


INTERMEDIO: 

1. Crea un programa que pida al usuario un número y determine si es un número primo o no.
2. Crea un programa que pida al usuario una cadena de texto y devuelva la cantidad de palabras que tiene.
3. Crea una clase "Rectángulo" que tenga propiedades para el ancho y el alto. Crea un método que calcule el área del rectángulo y otro método que calcule el perímetro.
4. Crea una clase "Cuenta bancaria" que tenga propiedades para el saldo y el nombre del titular. Crea métodos para depositar y retirar dinero de la cuenta.
5. Crea un programa que pida al usuario una lista de números y luego los ordene de menor a mayor utilizando el algoritmo de ordenamiento de selección.
6. Crea un programa que lea un archivo de texto y cuente cuántas veces aparece cada palabra en el archivo.
7. Crea un programa que simule el lanzamiento de un dado de 6 caras y cuente cuántas veces sale cada número después de un número determinado de lanzamientos.
8. Crea un programa que calcule la distancia entre dos puntos en un plano cartesiano.
9. Crea una clase "Libro" que tenga propiedades para el título, el autor y el número de páginas. Crea un método que devuelva una cadena de texto con la información del libro.
10. Crea un programa que pida al usuario una lista de números y luego calcule la media, la desviación estándar y el rango de los números.

Espero que estos ejercicios te ayuden a mejorar tus habilidades de programación en C#!

*/


namespace Basico
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1.
            //Console.Write("Dame la cantidad de números que quieres sumar: ");
            //int countNumbers = Convert.ToInt32(Console.ReadLine());
            //int sumNumbers = 0;
            //int number = 0; 
            //for (int i = 0; i < countNumbers; i++) {
            //    Console.Write("Dame un número: "); 
            //    number = Convert.ToInt32(Console.ReadLine());
            //    sumNumbers += number;
            //}
            //Console.WriteLine($"La suma de los números es: {sumNumbers}");

            //2. 
            //Console.Write("¿Quien eres? "); 
            //string nameAr = Console.ReadLine();
            //string response = Saludar(nameAr);
            //Console.WriteLine(response);


            //3. Par
            //Console.Write("Digite un número: "); 
            //int numberAr = Convert.ToInt32(Console.ReadLine());
            //bool response = EsPar(numberAr);
            //Console.WriteLine(response);


            //4. primo
            //Console.Write("Ingrese un número: ");
            //int numberAr = Convert.ToInt32(Console.ReadLine()); 
            //Console.WriteLine(IsPrime(numberAr));

            //5. Factorial
            //Console.Write("Ingrese un número: ");
            //int numberAr = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Factorial(numberAr));

            //INTERMEDIO

            //6. Cantidad de palabras

            //Console.Write("Dame una frase: ");
            //string s = Console.ReadLine(); 
            //Console.WriteLine(CountLetters(s));

            //7.Crea un programa que simule el lanzamiento de un dado de 6 caras y cuente cuántas veces sale cada número después de un número determinado de lanzamientos.

            //List<int> listaCaras = ContarCarasDado(6);
            //foreach (var cara in listaCaras)
            //{
            //    Console.WriteLine(cara);
            //}

        }

        public static List<int> ContarCarasDado(int numeroTiros)
        {

            Random random = new Random();

            List<int> listaCaras = new List<int>() { 0, 0, 0, 0, 0, 0 };

            for (int i = 1; i <= numeroTiros; i++)
            {
                  int tiro = random.Next(1,7);

                Console.WriteLine($"Tiro {i} sale {tiro}");

                switch (tiro)
                {
                    case 1:
                        listaCaras[0]++;
                        break;
                    case 2:
                        listaCaras[1]++;
                        break;
                    case 3:
                        listaCaras[2]++;
                        break;
                    case 4:
                        listaCaras[3]++;
                        break;
                    case 5:
                        listaCaras[4]++;
                        break;
                    case 6:
                        listaCaras[5]++;
                        break;
                }

            }

            return listaCaras; 
                    
            
        }


        public static int CountLetters(string s) {

            int numberLetters = 0; 
            
            foreach (char c in s)
            {
                numberLetters++;
            }

            return numberLetters;     
        }

        //--------------------Basicos

        public static int Factorial(int numberPa)
        {
            int factorial = 1;

            for (int i = numberPa; i >= 1; i--)
            {
                factorial *= i;
            }        
    
            return factorial;

        }

        public static bool IsPrime(int numberPa)
        {
            bool isPrime = true; 

            for (int i = 2; i < numberPa; i++)
            {

                if (numberPa % i == 0)
                {
                    isPrime = false;
                }


            }
            return isPrime;
        }

        public static string Saludar(String namePa)
        {

            return $"Hello {namePa}"; 

        }

        public static bool EsPar(int numberPa)
        {
            bool esPar = false;

                if (numberPa % 2 == 0)
                {
                    esPar = true;
                }

            return esPar;

        }
    }
}
