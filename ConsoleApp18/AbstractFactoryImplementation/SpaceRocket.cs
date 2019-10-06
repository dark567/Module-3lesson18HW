using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18.AbstractFactoryImplementation
{
    class SpaceRocket : IFactory<SpaceRocket>
    {
        public TProduct Build<TProduct>() where TProduct : IProduct<SpaceRocket>, new()
        {
            Console.WriteLine("Creating SpaceRocket: " + typeof(TProduct));
            return new TProduct();
        }
    }
}
