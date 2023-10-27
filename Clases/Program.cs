/*
Tipos de memoria: 

La memoria depende del tipo. 

Hay dos tipos de memoria. 

Memoria Stack (pila): 

lIFO.Tal cuál que JS. 

Ilera de platos. 

Memoria HEAP (Montón): 

Se asigna cierto tipos de objetos, se casan sin orden. Este tamañao es limitado. 

Seria como cajas amontonadas son orden. 

Crear un objeto literal es utilizar la memoria Heap. 

Cuando se hace referencia a un objeto, este lo que hace es apuntar a la memoria HEAP (Una memoria no definida, pues en parte el objeto no está definido) 


(imagen)
*/

using static System.Net.Mime.MediaTypeNames;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Program
    {

        static void Main(string[] args)
        {

            /*
             * Miembros de la Clase: (DATOS Y COMPORTAMIENTO). Componentes de la clase. Siempre debemos intentar que sean privados.
             * 
             * DATOS: 
             * Campos(atributos)
             * Constantes
             * 
             * COMPORTAMIENTO: 
             * Propiedades
             * Metodos
             * Constructores
             * Finalizadores
             * 
             */

            //Create object instance from class.
            Car carroUno = new Car();
            carroUno.Color = "Blue"; //Accder con las propiedades con getter. 
            //carroUno.combustible = "Diesel"; //error, no tiene setter. 
            carroUno.ccMotor = 2000;


            //Console.WriteLine(carroUno.Color); //Blue

            carroUno.Acelerar(); //Acelerar

            if (carroUno.Acelerar()) //se imprime acá también
            {
                Console.WriteLine("Acelerando correctamente =)");
            }

            Car.TestStatic("El main con el nombre de la clase.");

            //TO STRING. Nos de vuelve una cadena que representa al objeto actual. 

            Console.WriteLine(carroUno.ToString()); //Seccion2.Car. (Me muestra la referencia, pero puedo modificarlo @override al método).
       
            //Sobrecarga de métodos
            string nameAndLastname;

            Names names = new Names();

            nameAndLastname = names.Concatenar("Eulaloquita", "Buendia");

            Console.WriteLine(nameAndLastname);

            nameAndLastname = names.Concatenar("Sara", "Gomez", "Eulaloquita"); //Consobrecarga. 

            Console.WriteLine(nameAndLastname);


            Random random = new Random();

            Console.WriteLine(random.Next(0, 100)); //rango entre 0 a 100. 

        }

        //Declaración de un campo: 
        int numbers = 0;


        /* Modificadores de acceso: quién puede acceder a mis recursos. 
            
            public: sin restricciones. 
            protected
            internal 
            private: solo accesibles en el bloque de çódigo. 
            
            ¿Cómo acceder a los campos privados desde el exterior? 
            - Propiedades: mecanismo sencillo y flexible para acceder a campos privados. Son métodos especializados. Acceder facilmente al campo. Estos son los get y set. 

            Cuatro tipos de propiedades: lectura y escritura. Solo lectura. Solo escritura. Propiedades autoimplementadas. 


         */

    }


    //CREATE CLASS: (public o internal):
    //[modificador] [class] [identificador]

    public class Car
    {

        //CAMPOS
        private string color = "verde", modelo = "cx-3", combustible = "Diesel", año = "2019", numPuertas = "4";
        //private byte año, numPuertas;
        public int ccMotor;

        //CONSTRUCTOR: miembro especializado. Sirve para iniclizar nuestro objeto. Puede ser publico o privado. 
        public Car()
        {
            ccMotor = 2000;
        }


        //PROPIEDADES: [acceso] [tipo] [nombre]
        public string Color
        {
            //descriptor de acceso get. Optener al campo privado. 
            //miembro => expresion; 
            get => color;

            //descriptor de acceso set

            set { color = value; }
        }

        public string Modelo
        {
            get { return modelo; }

            set => modelo = value;
        }

        //METODOS

        public bool Acelerar()
        {
            bool acelerar = true;
            Console.WriteLine("Acelerar");
            TestStatic("Acelerar");
            return acelerar;
        }

        public bool Frenar()
        {
            bool frenar = true;
            Console.WriteLine("Acelerar");
            return frenar;
        }

        public void Velocidades(ref byte velocidadPa)
        {
            velocidadPa++; //Modificamos el campo referido desde el método. 
            Console.WriteLine("Cambio de Velocidad");

        }

        public static void TestStatic(string callingPa)
        {
            Console.WriteLine("Soy un método static llamado desde {0}", callingPa);
        }

        //Invalidando el método ToString()
        public override string ToString()
        {
            string message;

            message = "Modelo: " + modelo + "\nColor: " + color + "\nCombustible: " + combustible + "\naño: " + año + "\nMotor: " + ccMotor;

            return message;
        }

    }


    class Names
    {

        //Sobre carga de métodos: tener varias versiones de un mismo método. 

        public string Concatenar(String namePa, string lastnamePa)
        {
            string nameComplete;

            nameComplete = namePa + " " + lastnamePa;

            return nameComplete;
        }

        public string Concatenar(string namePa, string lastnamePa, string nickname)
        {
            string nameComplete;

            nameComplete = namePa + " " + lastnamePa + " " + nickname;

            return nameComplete;
        }

    }



}


