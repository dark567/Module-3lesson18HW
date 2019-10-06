using ConsoleApp1.ProductLayer;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var productOne = new ProductOne();
            var productTwo = new ProductTwo();

            Console.WriteLine($"{productOne.DoWorkOne()}");
            Console.WriteLine($"{productTwo.WorkWithProductOne(productOne)}");

            Console.ReadLine();
        }
    }
}
