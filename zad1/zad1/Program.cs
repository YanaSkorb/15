﻿using System;
using System.Collections.Generic;

namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            for (int i = 0; i < 10; i++)
            {
                myList.Add(i);
            }

            foreach (var item in myList)
            {
                Console.Write("{0} | ", item);
            }

            var count = myList.count;

            Console.WriteLine("\nКоличество элементов: {0}", count);
            Console.WriteLine("\n7-oй элемент: {0}", myList[6]);
            Console.ReadLine();
        }
    }
}


