using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {


            var list = new List(10);

            list.InsertAt(0, "Hello");
            list.PrintReverse();


            Console.WriteLine(list.InsertAt(5, " there!"));
            list.PrintReverse();

            Console.WriteLine(list.RemoveAt(0));

            list.PrintReverse();

        }
    }
}


