using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person eulajecutiva = new Person("Sara", "Gomez");

            eulajecutiva.CcNumber = "1000660362";

            Console.WriteLine(eulajecutiva.ToString());

            BankAccount bankAccount = new BankAccount(eulajecutiva, 2200, "362");

            int optionUser;

            do
            {
                Console.WriteLine("\nBank Options: \n1.Deposito \n2.Retiro \n3.Saldo \n4.Mostrar info cuenta \n0.Salir");

                optionUser = Convert.ToInt32(Console.ReadLine());

                bankAccount.BankMenu(optionUser);

            } while (optionUser != 0);




        }


        public class Person
        {

            private string name, lastname, id, locker, bank, ccNumber;

            public Person(string name, string lastname)
            {
                this.name = name;
                this.lastname = lastname;

                //id
                this.id = generateId();
                //locker
                this.locker = generateLocker();
                //bank
                this.bank = generateBank();

            }

            Random random = new Random();

            public string CcNumber
            {
                set { ccNumber = value; }
            }

            public string generateBank()
            {

                string bank;
                int optionBank = random.Next(1, 3); //1,2

                switch (optionBank)
                {
                    case 1:
                        bank = "BBVA";
                        break;
                    case 2:
                        bank = "Santander";
                        break;
                    default:
                        return "ERROR";
                }

                return bank;
            }

            public string generateLocker()
            {

                string locker = "";

                for (int i = 0; i < 2; i++)
                {
                    locker += random.Next(10).ToString(); 
                }

                return locker; //Dos números del 1 al 9
            }

            public string generateId()
            {

                string id = "";

                for (int i = 0; i < 10; i++)
                {
                    id += random.Next(10).ToString();
                }

                return id;
            }

            public override string ToString()
            {
                return "Name: " + name + "\n ccNumber " + ccNumber + "\nlastname: " + lastname + "\nid: " + id + "\nlocker: " + locker + "\nbank: " + bank;
            }
        }

        public class BankAccount
        {
            private Person person;
            private double cash;
            private string nit;


            public BankAccount(Person personPa, double cash, string nit)
            {
                person = personPa;
                this.cash = cash;
                this.nit = nit;
            }

            public void Deposito(ref double depositoPa)
            {

                this.cash += depositoPa;

            }

            public void Retiro(ref double retiroPa)
            {
                this.cash -= retiroPa;
            }

            public override string ToString()
            {
                return "Persona: " + person + "\nSaldo: " + this.cash + "\nNit: " + this.nit;
            }

            public void BankMenu(int optionUser)
            {


                switch (optionUser)
                {
                    case 1:
                        Console.WriteLine("Deposito");
                        Console.Write("Digite el deposito que desea realizar: ");
                        double deposito = Convert.ToDouble(Console.ReadLine());
                        Deposito(ref deposito);
                        Console.WriteLine("Valor saldo actual: {0}", this.cash);
                        break;
                    case 2:
                        Console.WriteLine("Retiro");
                        Console.Write("Digite el retiro que desea realizar: ");
                        double retiro = Convert.ToDouble(Console.ReadLine());
                        Retiro(ref retiro);
                        Console.WriteLine("Valor saldo actual: {0}", this.cash);
                        break;
                    case 3:
                        Console.WriteLine("Saldo: {0}", this.cash);
                        break;
                    case 4:
                        Console.WriteLine("Info cuenta: ");
                        Console.WriteLine(ToString());
                        ;
                        break;
                    default:
                        Console.WriteLine("Hasta luego!");
                        break;
                }

            }

        }

    }
}
