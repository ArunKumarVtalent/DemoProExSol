﻿using System;

namespace DemoProEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, res;
            a = 10;
            b = 20;
            res = a + b;
            Console.WriteLine("The Sum is : " + res);

            res = a - b;
            Console.WriteLine("The Sub is : " + res);

            res = a * b;
            Console.WriteLine("The Mul is : " + res);
            
            Console.WriteLine("Program Completed...!");

            Console.ReadKey();
        }
    }
}
