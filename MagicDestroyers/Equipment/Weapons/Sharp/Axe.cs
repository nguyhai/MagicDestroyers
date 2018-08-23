using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Axe : Sharp
    {
        private const int DefaultDamagePoints = 10;

        public Axe()
            :this(DefaultDamagePoints)
        {

        }

        public Axe(int damagePoints)
        {
            Damage = damagePoints;
        }

        public void HackNSlash()
        {
            throw new NotImplementedException();
        }


    }
}
