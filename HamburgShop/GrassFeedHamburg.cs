using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgShop
{
    internal class GrassFeedHamburg : IHamburg
    {
        public IHamburg Clone()
        {
            return new GrassFeedHamburg();
        }

        public override string ToString()
        {
            return "Grass Feed Hamburg";
        }
    }
}
