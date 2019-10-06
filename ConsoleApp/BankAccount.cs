using System;

namespace ConsoleApp
{
    class BankAccount<T>
    {
        public Guid Id { get; set; }
        public T Account { get; set; }
        public int Sum { get; set; }

        public BankAccount(T account, int sum)
        {
            this.Id = Guid.NewGuid();
            this.Account = account;
            this.Sum = sum;
        }

    }
}
