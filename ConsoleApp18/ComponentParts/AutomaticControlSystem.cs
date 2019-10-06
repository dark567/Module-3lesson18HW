using ConsoleApp18.AbstractFactoryImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18.ComponentParts
{
    class AutomaticControlSystem : IProduct<SpaceRocket>, IProduct<SpacePlane>
    {
        public void Operate()
        {
            Console.WriteLine("Operating AutomaticControlSystem.");
        }

        public void RudderSpecificOperation()
        {
            Console.WriteLine("Performing AutomaticControlSystem-specific operation.");
        }
    }
}
