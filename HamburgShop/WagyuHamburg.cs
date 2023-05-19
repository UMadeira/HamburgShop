using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgShop
{
    internal class WagyuHamburg : IHamburg
    {
        public IHamburg Clone()
        {
            return new WagyuHamburg();
        }

        public override string ToString()
        {
            return "Wagyu Hamburg";
        }
    }
}
