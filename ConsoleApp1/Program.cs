using ConsoleApp1.ProductLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
