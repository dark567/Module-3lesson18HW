using ConsoleApp18.AbstractFactoryImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18.FinalProduct
{
    class Orion : IProduct<SpacePlane>, IProduct<SpaceRocket>
    {
        public void Operate()
        {
            Console.WriteLine("Orion Operate");
        }

        public void OrionSpecificationOperation()
        {
            Console.WriteLine("Orion created");
        }
    }
}
