using ConsoleApp18.AbstractFactoryImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18.ComponentParts
{
    class PlaneBody<IFactory> : IProduct<SpacePlane>
    {
        public void Operate()
        {
            Console.WriteLine("Operating PlaneBody");
        }

        public void FrameSpecificOperation()
        {
            Console.WriteLine("Performing PlaneBody-specific operation.");
        }
    }
}
