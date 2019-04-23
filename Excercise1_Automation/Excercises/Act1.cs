using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise1_Automation.Excercises
{
    public class Act1
    {
        public string Comparison(string param1, string param2)
        {
            if(param1.Equals(param2))
                return "The two words are equals \n";

            if (param1.Length == param2.Length)
                return "The two words are different but they have same lenght \n";

            return "Two words are differents \n";
        }


        public void Biggest(int[] numbers)
        {
            numbers = numbers.OrderByDescending(s => s).ToArray();
            Console.WriteLine("The biggest number in the list is: "  + numbers.First());
            Console.WriteLine();
        }

        public void Sortlist(List<string> strings)
        {
            strings = strings.OrderBy(s => s).ToList();
            Console.WriteLine("Sorting from smallest to the biggest");
            strings.ForEach(s => {
                Console.WriteLine(s);
            });

            strings = strings.OrderByDescending(s => s).ToList();
            Console.WriteLine("Sorting from Biggest to the Smallest");
            strings.ForEach(s => {
                Console.WriteLine(s);
            });
        }

        public int lenght(string word)
        {
            return word.Length;
        }
    }
}
