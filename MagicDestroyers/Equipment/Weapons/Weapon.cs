using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons
{
    public class Weapon
    {
        private int _damage;

        public int Damage
        {
            get
            {
                return _damage;
            }
            private set
            {
                if (value >= 1)
                {
                    _damage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $"Damage cannot be less than 1");
                }
            }
        }
    }
}
