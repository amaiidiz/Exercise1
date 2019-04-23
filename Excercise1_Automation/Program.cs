using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise1_Automation.Excercises;

namespace Excercise1_Automation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var act1 = new Act1();
            var act2 = new Act2();
            string palabra1;
            string palabra2;
            string palabra3;
        
            Console.WriteLine("****** EXERCISE 1 ******\n");
            Console.WriteLine("Enter first word:");
            palabra1 = Console.ReadLine();
            Console.WriteLine("Enter second word:");
            palabra2 = Console.ReadLine();
            var result1 = act1.Comparison(palabra1.ToLower(), palabra2.ToLower());
            Console.WriteLine(result1);

            var ListNumbers = new List<int>() { 8, 9, 16, 12, 2, 6, 1, 3 };
            Console.WriteLine("****** EXERCISE 2 ******\n");
            Console.WriteLine("The List have the following elements:   8, 9, 16, 12, 2, 6, 1, 3");
            act1.Biggest(ListNumbers.ToArray());

            Console.WriteLine("****** EXERCISE 3 ******\n");
            var liststrings = new List<string>() { "9", "2", "4", "1" };
            Console.WriteLine("The List have the following elements: 9, 2, 4, 1 \n");
            act1.Sortlist(liststrings);

            Console.WriteLine("****** EXERCISE 4 ******\n");
            Console.WriteLine("Enter the string:");
            palabra3 = Console.ReadLine();
            var Length = act1.lenght(palabra3);
            Console.WriteLine("The length of the string is: " + Length );
            Console.WriteLine();


            var lista = new List<int>() { 8, 9, 16, 12, 2, 6, 1 ,3 };
            Console.WriteLine("****** EXERCISE 5 ******\n");
            Console.WriteLine("The List have the following elements:  8, 9, 16, 12, 2, 6, 1 ,3 ");
            Console.WriteLine("And the first 5 values are:");
            act2.list(lista);
            Console.WriteLine();

            var lista2 = new List<int>() { 7, 8, 3, 6, 1, 2, 10 };
            Console.WriteLine("****** EXERCISE 6 ******\n");
            Console.WriteLine("The List have the following elements: 7, 8, 3, 6, 1, 2, 10");
            act2.smallest(lista.ToArray());
            Console.WriteLine();


            Console.WriteLine("****** EXERCISE 7 ******\n");
            act2.dictionary();

            Console.ReadLine();
        }
    }
}
