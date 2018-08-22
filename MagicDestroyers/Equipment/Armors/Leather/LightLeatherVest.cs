using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors.Leather
{
    public class LightLeatherVest : Leather
    {
        private const int DefaultArmorPoints = 5;

        // Constructors, 1 default and one that takes an argument. The default one will take DefaultArmorPoints
        public LightLeatherVest()
            : this(DefaultArmorPoints)
        {

        }

        public LightLeatherVest(int armorPoints)
        {
            ArmorPoints = armorPoints;
        }
    }
}
