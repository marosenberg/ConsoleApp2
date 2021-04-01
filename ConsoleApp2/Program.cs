using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           // double[] ar = new double[] { 5, 4, 3, 2, 1 };
            myMethod("Me", 1,2,3,4,5);
            Console.ReadKey();
        }


        static void myMethod(string name, params double[] d)
        {
            foreach (var item in d)
            {
                Console.WriteLine(item);
            }
        }
    }
}
