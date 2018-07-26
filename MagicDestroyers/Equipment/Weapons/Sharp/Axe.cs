using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Axe
    {
        private int _damage;
        
        public Axe()
        {
            _damage = 10; // We only want to set the damage to 10 for now. 
        }

        public void HackNSlash()
        {
            throw new NotImplementedException();
        }

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
