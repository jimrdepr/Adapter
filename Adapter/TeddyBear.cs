using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class TeddyBear : ToyBear
    {
        public void Hug()
        {
            Console.WriteLine("Toy bear is hugging you");
        }
    }
}
