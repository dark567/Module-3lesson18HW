using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.AbstactLayer
{
    public class FactoryTwo : IAbstractFactory
    {
        public IAbstractProductFour CreateProductFour()
        {
            throw new NotImplementedException();
        }

        public IAbstractProductOne CreateProductOne()
        {
            throw new NotImplementedException();
        }

        public IAbstractProductThree CreateProductThree()
        {
            throw new NotImplementedException();
        }

        public IAbstractProductTwo CreateProductTwo()
        {
            throw new NotImplementedException();
        }
    }
}
