using DemoProEx.Operations;
using System;

namespace DemoProEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, res;
            a = 10;
            b = 20;

            AirthmaticOperations obj = new AirthmaticOperations();

            res = obj.Add(a, b);
            Console.WriteLine("The Sum is : " + res);

            res = obj.Sub(a, b);
            Console.WriteLine("The Sub is : " + res);

            res = obj.Mul(a, b);
            Console.WriteLine("The Mul is : " + res);

            Console.WriteLine("Program Completed...!");

            Console.ReadKey();
        }
    }
}
