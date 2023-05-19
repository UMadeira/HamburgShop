using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgShop
{
    internal class BrisketHamburg : IHamburg
    {
        public IHamburg Clone()
        {
            return new BrisketHamburg();
        }

        public override string ToString()
        {
            return "Brisket Hamburg";
        }
    }
}
