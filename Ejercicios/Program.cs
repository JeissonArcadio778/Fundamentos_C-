using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Palindromo
            Console.Write("Digite la palabra: ");
            string word = Console.ReadLine();

            List<char> wordList = word.ToList();

            wordList.Reverse();
            string wordReversed = ""; 

            foreach(char c in wordList)
            {
                Console.WriteLine(c);
                wordReversed += c;
            }

            if (wordReversed == word)
            {
                Console.WriteLine("PALINDROMO");
            }







        }
    }
}
