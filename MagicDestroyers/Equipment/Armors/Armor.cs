using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors
{
    public abstract class Armor
    {
        private int _armorPoints;

        public int ArmorPoints
        {
            get
            {
                return _armorPoints;
            }
            set
            {
                if (value >= 1)
                {
                    _armorPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $"The amount of armor points cannot be less than 1");
                }
            }
        }


    }
}
