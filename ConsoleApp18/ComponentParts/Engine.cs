using ConsoleApp18.AbstractFactoryImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18.ComponentParts
{
    class Engine<TFactory> : IProduct<TFactory>
    {
        public void Operate()
        {
            Console.WriteLine("Operating Engine.");
        }

        public void EngineSpecificOperation()
        {
            Console.WriteLine("Performing Engine-specific operation.");
        }
    }
}
