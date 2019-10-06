using ConsoleApp18.AbstractFactoryImplementation;
using ConsoleApp18.ComponentParts;
using ConsoleApp18.FinalProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.DependentCalls();
            Console.WriteLine(Environment.NewLine);
            program.RelatedCalls();


            Console.ReadLine();
        }

        private void DependentCalls()
        {
            Console.WriteLine("##DEPENDENT CALLS:" + Environment.NewLine);

            Console.WriteLine("*Space Rockets Factory:");
            Factory<SpaceRocket> rocketFactory = new Factory<SpaceRocket>();

            IProduct<SpaceRocket> rocketProduct = rocketFactory.Create<Engine<SpaceRocket>>();
            rocketProduct.Operate();

            IProduct<SpacePlane> rocketAutomaticControlSystem = rocketFactory.Create<AutomaticControlSystem>();
            rocketAutomaticControlSystem.Operate();

            // Example of using a product specific function.
            RocketBody<SpaceRocket> rocketBody = rocketFactory.Create<RocketBody<SpaceRocket>>();
            rocketBody.Operate();
            rocketBody.FrameSpecificOperation();
            Console.WriteLine(new string('-', 25));


            Console.WriteLine("*Space Plane Factory:");
            Factory<SpacePlane> planeFactory = new Factory<SpacePlane>();

            IProduct<SpacePlane> planeEngineProduct = planeFactory.Create<Engine<SpacePlane>>();
            planeEngineProduct.Operate();

            IProduct<SpacePlane> planeACSProduct = planeFactory.Create<AutomaticControlSystem>();
            planeACSProduct.Operate();

            PlaneBody<SpacePlane> planeBody = planeFactory.Create<PlaneBody<SpacePlane>>();
            rocketBody.Operate();
            rocketBody.FrameSpecificOperation();

            Console.WriteLine(new string('-', 25));


            // Example of a car factory creating a plane frame.
            rocketFactory.Create<RocketBody<SpaceRocket>>();

            // Example of a plane factory creating a car frame.
            planeFactory.Create<PlaneBody<SpacePlane>>();

            Console.WriteLine(new string('*', 25));

        }

        private void RelatedCalls()
        {
            Console.WriteLine("##RELATED CALLS:" + Environment.NewLine);

            Console.WriteLine("*Rocket Factory:");
            Factory<SpaceRocket> rocketFactory = new Factory<SpaceRocket>();

            // Example of using interface functions.
            IProduct<SpaceRocket> rocketProduct = rocketFactory.Create<Dragon>();
            rocketProduct.Operate();

            IProduct<SpaceRocket> rocketProductProtonM = rocketFactory.Create<ProtonM>();
            rocketProductProtonM.Operate();

            // Example of using a product specific function.
            Falcon falcon = rocketFactory.Create<Falcon>();
            falcon.Operate();
            falcon.FalconSpecificationOperation();
            Console.WriteLine(new string('-', 25));

            Console.WriteLine("*Plane Factory:");
            Factory<SpacePlane> planeFactory = new Factory<SpacePlane>();

            IProduct<SpacePlane> orion = planeFactory.Create<Orion>();
            orion.Operate();
            Console.WriteLine(new string('-',25));

            Console.WriteLine("*Rocket and Plane Factory:");
            Orion orion1 = rocketFactory.Create<Orion>();
            orion1.Operate();
            orion1.OrionSpecificationOperation();

            Orion orion2 = planeFactory.Create<Orion>();
            orion2.Operate();
            orion2.OrionSpecificationOperation();

            Console.WriteLine(new string('-', 25));
        }
    }
}
