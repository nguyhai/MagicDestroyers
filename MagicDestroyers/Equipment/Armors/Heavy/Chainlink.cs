using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors.Heavy
{
    public class Chainlink
    {
        private int _armorPoints;
        
        public Chainlink()
        {

        }

        public int ArmorPoints
        {
            get
            {
                return _armorPoints;
            }
            set
            {
                if (value >= 1 )
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
