using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Grizzly : Bear
    {
        public void Maul()
        {
            Console.WriteLine("Bear has maulled you");
        }

        public void Hibernate()
        {
            Console.WriteLine("Bear is hibernating");
        }
    }
}
