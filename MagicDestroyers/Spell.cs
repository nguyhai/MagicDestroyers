using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers
{
    public class Spell
    {
        private int _manaCost;
        private int _damage;

        public int ManaCost
        {
            get
            {
                return _manaCost;
            }
            set
            {
                _manaCost = value;
            }
        }

        public int Damage
        {
            get
            {
                return _damage;
            }
            set
            {
                _damage = value;
            }
        }

        public Spell()
        {
            ManaCost = 10;
            Damage = 10;
        }


    }
}
