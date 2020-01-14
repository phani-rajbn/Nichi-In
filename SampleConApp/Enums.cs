using System;

namespace SampleConApp
{
    enum TransportMode { PublicTransport =1, Car, Bike };
    
    class Enums
    {
        static void Main(string[] args)
        {
            Array values = Enum.GetValues(typeof(TransportMode));
            foreach (var value in values) Console.WriteLine(value);
            Console.WriteLine("Please Type one from the list above");
            string selectedMode = Console.ReadLine();
            TransportMode mode = (TransportMode)Enum.Parse(typeof(TransportMode), selectedMode, true);//UNBOXING...
            Console.WriteLine("The selected mode is "+ mode);
        }
    }
}
