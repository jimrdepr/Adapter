using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class BearAdapter : ToyBear
    {
        public Bear adapt;
        public BearAdapter(Bear bear)
        {
            adapt = bear;
        }
        public void Hug()
        {
            adapt.Maul();
        }
    }
}
