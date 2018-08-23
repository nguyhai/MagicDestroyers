using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Staff : Blunt
    {

        private const int DefaultDamagePoints = 10;

        public Staff()
            :this(DefaultDamagePoints)
        {

        }

        public Staff(int damagePoints)
        {
            Damage = damagePoints;
        }

        public void Empower()
        {
            throw new NotImplementedException();
        }


    }
}
