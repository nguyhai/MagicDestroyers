using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Sword : Sharp
    {
        
        public Sword()
        {
            Damage = 10; // We only want to set the damage to 10 for now. 
        }

        public void Bloodthirst()
        {
            throw new NotImplementedException();
        }
    }
}
