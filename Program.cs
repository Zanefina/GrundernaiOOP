using System;

namespace GrundernaiOOP
{
    class Program
    {
        static void Main(string[] args)
        {   //The first Circle object and its area and volume.
            Circle c1 = new Circle(3.141f, 5);
            Console.WriteLine("Arean för cirkel med radie 5 är: {0}",c1.GetArea());
            Console.WriteLine("Volymen för cirkel med radie 5 är: {0} ",c1.GetVolume());

            Console.WriteLine("-------------------------------------------");
            //The second Circle object and its area and volume .
            Circle c2 = new Circle(3.141f, 6);
            Console.WriteLine("Arean för cirkel med radie 6 är: {0}",c2.GetArea());
            Console.WriteLine("Volymen för cirkel med radie 6 är: {0} ",c2.GetVolume());

            Console.WriteLine("------------------------------------------------");
            //The triangle object and its area and volume.
            Triangle t1 = new Triangle(8, 4);
            Console.WriteLine("Arean av triangeln är: {0}", t1.GetArea());
            Console.WriteLine("Volymen av triangeln är: {0}", t1.GetVolume());

        }
    }
}
