using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Spellcaster : Character
    {
        private int _manaPoints;

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
