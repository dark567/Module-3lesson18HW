using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18.AbstractFactoryImplementation
{
    class SpacePlane : IFactory<SpacePlane>
    {
        public TProduct Build<TProduct>() where TProduct : IProduct<SpacePlane>, new()
        {
            Console.WriteLine("Creating new SpacePlane" + typeof(TProduct));
            return new TProduct();
        }
    }
}
