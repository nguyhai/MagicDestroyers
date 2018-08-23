using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Hammer : Blunt
    {
        private const int DefaultDamagePoints = 10;
        
        public Hammer()
            :this(DefaultDamagePoints)
        {
            
        }

        public Hammer(int damagePoints)
        {
            Damage = damagePoints;
        }

        public void Stun()
        {
            throw new NotImplementedException();
        }
    }
}
