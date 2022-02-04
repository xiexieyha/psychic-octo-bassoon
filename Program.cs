// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Fibonacci
    {
        public static void Main(string[] args)
        {
            int a = 1, b = 1, c = 0, length = 10;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(a + " ");
                c = a + b;
                a = b;
                b = c;
            }
        }

        public static int Fibonaccimethod(int n)
        {
            if (n == 0 || n == 1) return 1;

            return Fibonaccimethod(n - 1) + Fibonaccimethod(n - 2);
        }
    }
}
