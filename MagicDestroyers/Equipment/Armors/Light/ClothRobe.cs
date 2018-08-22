using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors.Light
{
    public class ClothRobe : Light
    {
        private const int DefaultArmorPoints = 3;

        // Constructors, 1 default and one that takes an argument. The default one will take DefaultArmorPoints
        public ClothRobe()
            : this(DefaultArmorPoints)
        {

        }

        public ClothRobe(int armorPoints)
        {
            ArmorPoints = armorPoints;
        }
    }
}
