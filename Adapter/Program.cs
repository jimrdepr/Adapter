using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Grizzly bear = new Grizzly();
            TeddyBear teddy = new TeddyBear();
            BearAdapter toy_adapt = new BearAdapter(bear);

            Console.WriteLine("Grizzly");
            bear.Maul();
            bear.Hibernate();

            Console.WriteLine("Teddy Bear");
            teddy.Hug();

            Console.WriteLine("Teddy to Grizzly");
            toy_adapt.Hug();        
 }
    }
}
