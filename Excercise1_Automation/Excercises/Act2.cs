using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise1_Automation.Excercises
{
    class Act2
    {
        public void list(List<int> numeritos)
        {
            var count = 1;
            foreach (var n in numeritos)
            {
                if (count <= 5)
                    Console.WriteLine(n);
                count++;
            }
        }

        public void smallest (int[] numeritos2)
        {
            numeritos2 = numeritos2.OrderBy(s => s).ToArray();
            Console.WriteLine("The smallest number in the array is: " + numeritos2.First());
        }

        public void dictionary()
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            myDictionary.Add(1, "One");
            myDictionary.Add(2, "Two");
            myDictionary.Add(3, "Three");

            for (int pos = 1; pos < 4; pos++)
                // Console.WriteLine($"Value of key {pos} : {myDictionary.FirstOrDefault(d => d.Key == pos).Value}");
                Console.WriteLine("Position of the Key:" +pos + ", Value:" +myDictionary.FirstOrDefault(d => d.Key == pos).Value);
        }
            
    }
}
