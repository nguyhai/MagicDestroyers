using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Sword : Sharp
    {

        private const int DefaultDamagePoints = 10;

        public Sword()
            :this(DefaultDamagePoints)
        {

        }

        public Sword(int damagePoints)
        {
            Damage = damagePoints;
        }

        public void Bloodthirst()
        {
            throw new NotImplementedException();
        }
    }
}
