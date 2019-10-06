using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            AccountCollection accounts = new AccountCollection();

            // show all
            IEnumerator account = accounts.GetEnumerator();
            while (account.MoveNext())
                Console.WriteLine(((BankAccount<string>)account.Current).Id + " : " + ((BankAccount<string>)account.Current).Account + " : " + ((BankAccount<string>)account.Current).Sum);

            

            Console.ReadKey();
        }
    }
}
