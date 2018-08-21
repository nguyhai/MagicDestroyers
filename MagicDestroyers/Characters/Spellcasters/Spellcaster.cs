using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Spellcaster : Character
    {
        private int _manaPoints;

        // For mages, we will use Mana Points instead of Ability points. Everything in our characters are going to inherit stuff from both the character + melee/spellcaster classes
        // Properties
        public int ManaPoints
        {
            get
            {
                return _manaPoints;
            }
            set
            {
                if (value >= 0 && value <= 50)
                {
                    _manaPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $"Ability Points cannot be Negative or over 10 for {base.Name}");
                    
                }
            }
        }



    }
}
