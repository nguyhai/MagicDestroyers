using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors.Heavy
{
    public class Chainlink : Heavy
    {
        private const int DefaultArmorPoints = 10;

        // Constructors, 1 default and one that takes an argument. The default one will take DefaultArmorPoints
        public Chainlink()
            : this(DefaultArmorPoints)
        {

        }

        public Chainlink(int armorPoints)
        {
            ArmorPoints = armorPoints;
        }
    }
}
