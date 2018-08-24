using MagicDestroyers.Characters.Melee;

namespace MagicDestroyers.Interfaces
{
    public interface ISpellcaster
    {
        // With Interfaces, we CANNOT Have access modifier
        int Mana { get; set; }

        void CastSpell(Warrior warrior);


    }
}
