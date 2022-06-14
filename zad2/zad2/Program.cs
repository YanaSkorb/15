using System;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDict = new MyDictionary<string, string>();

            myDict.Add("1", "One");
            myDict.Add("2", "Two");
            myDict.Add("3", "Three");


            foreach (var item in myDict)
            {
                Console.Write("{0} | {1}\n", item.key, item.value);

            }

            Console.WriteLine("Number of pairs: {0}", myDict.Count);

            Console.WriteLine("Choose: ");
            var key = Console.ReadLine();
            Console.WriteLine("{0}", myDict[key]);

            Console.ReadLine();
        }
    }
}
