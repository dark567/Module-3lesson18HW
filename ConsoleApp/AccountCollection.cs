using System.Collections;

namespace ConsoleApp
{
    class AccountCollection : IEnumerable, IEnumerator
    {
        private BankAccount<string>[] account = {
            new BankAccount<string>(account:"32156", sum: 100),
            new BankAccount<string>(account:"Buasdasds", sum: 200),
            new BankAccount<string>(account:"B12312us", sum: 150),
            new BankAccount<string>(account:"Buasdsas", sum: 190)
        };

        int index = -1;

        public object Current => account[index];

        public IEnumerator GetEnumerator()
        {
            // return this;
            for (int i = 0; i < account.Length; i++)
            {
                yield return account[i];
            }
        }

        public bool MoveNext()
        {
            if (index == account.Length - 1)
            {
                Reset();
                return false;
            }

            index++;
            return true;
        }

        public void Reset()
        {
            index = -1;
        }



        public void AddAccount()
        {
            BankAccount<string>[] account_ ;

            for (int i = 0; i < account.Length; i++)
            {
                account_[i] = account[i];
            }

            //account = account_;

            account = new BankAccount<string>(account: "32156", sum: 100);
        }
    }
}

