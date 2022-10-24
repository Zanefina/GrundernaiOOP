using System;

namespace GrundernaiOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(3.141f, 5);
            Console.WriteLine("Arean för cirkel med radie 5 är: {0}",c1.GetArea());
            Console.WriteLine("Volymen för cirkel med radie 5 är: {0} ",c1.GetVolume());

            Console.WriteLine("-------------------------------------------");

            Circle c2 = new Circle(3.141f, 6);
            Console.WriteLine("Arean för cirkel med radie 6 är: {0}",c2.GetArea());
            Console.WriteLine("Volymen för cirkel med radie 6 är: {0} ",c2.GetVolume());

        }
    }
}
