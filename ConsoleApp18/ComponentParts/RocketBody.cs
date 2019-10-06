using ConsoleApp18.AbstractFactoryImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18.ComponentParts
{
    class RocketBody<TFacrory> : IProduct<SpaceRocket>
    {
        public void Operate()
        {
            Console.WriteLine("Operating RocketBody.");
        }

        public void FrameSpecificOperation()
        {
            Console.WriteLine("Performing RocketBody-specific operation.");
        }
    }
}
