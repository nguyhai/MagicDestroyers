using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Sword
    {
        private int _damage;
        
        public Sword()
        {
            _damage = 10; // We only want to set the damage to 10 for now. 
        }

        public void Bloodthirst()
        {
            throw new NotImplementedException();
        }

        public int Damage
        {
            get // We want everyone to be able to see this value. 
            {
                return _damage;
            }
            private set // Only the sword should be able to modify this value. Remember, the private keyword makes it so that modifications can be done only in that class
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
