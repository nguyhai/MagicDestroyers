using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee;

namespace MagicDestroyers.Interfaces
{
    public interface ISpellcaster
    {
        // With Interfaces, we CANNOT Have access modifier
        int Mana { get; set; }

        // Instead of doing this, we can change the type to character and instead of targeting only Warriors, we can target ALL CHARACTERS (Anything with a basetype of character). 

        void CastSpell(Character character);


    }
}
