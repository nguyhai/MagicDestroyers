using System;

namespace MagicDestroyers.Characters.Melee
{
    // Even if melee is an abstract class, it can inherit from character, even though character is abstract
    public abstract class Melee : Character
    {
        private int _abilityPoints; 

        public int AbilityPoints
        {
            get
            {
                return _abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 50)
                {
                    _abilityPoints = value;
                }
                else
                {

                    throw new ArgumentOutOfRangeException(string.Empty, $"Ability Points cannot be Negative or over 10 for {base.Name}");
                }
            }
        }
    }
}
