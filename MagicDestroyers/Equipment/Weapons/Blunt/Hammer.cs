using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Hammer
    {
        private int _damage;
        
        public Hammer()
        {
            _damage = 10;
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


        public void Stun()
        {
            throw new NotImplementedException();
        }
    }
}
