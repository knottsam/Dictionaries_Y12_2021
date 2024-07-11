using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries_Y12_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> exampleDictionary = 
                new Dictionary<int, string>();


            exampleDictionary.Add(1, "Maz");
            exampleDictionary.Add(2, "Jack");
            exampleDictionary.Add(3, "Szymon");
            exampleDictionary.Add(4, "Maz");//Initial Commit

            foreach (KeyValuePair<int, string> pair in exampleDictionary)
            {
                Console.WriteLine($"The key {pair.Key}'s value is: {pair.Value}.");
            }

            Console.ReadLine();
        }
    }
}
