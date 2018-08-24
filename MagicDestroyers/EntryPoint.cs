using Enumerations;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcasters;
using System;

namespace MagicDestroyers
{
    class EntryPoint
    {
        static void Main()
        {
            //Warrior goodGuy = new Warrior();
            //Warrior badGuy = new Warrior();

            //try
            //{

            //}
            //catch (ArgumentOutOfRangeException ex) // Here is where we catch the exception that we were expecting. Gave it variable ex. This ArgumentOutOfRange exception ties to what was in our setter
            //{
            //    Console.WriteLine(ex.Message);
            //}

            // Instantiating our objects, if no value is provided, default values are used (these are taken in from the constructor)

            Warrior warrior = new Warrior("Hai", 10, 150, Faction.Melee);
            //warrior.Move(500);

            Mage mage = new Mage();
            //mage.Move(500);

            //Assassin assasin = new Assassin("Tester1", 20);

            //warrior.Addition(4, 5);

            //mage.Addition(10, 10);

            Console.WriteLine($"The warrior has {warrior.HealthPoints} health");
            Console.WriteLine($"The mage has {mage.Mana} mana.");

            Console.WriteLine("The mage casts FIRE SPELL");
            mage.CastSpell(warrior);

            Console.WriteLine($"The warrior has {warrior.HealthPoints} health");
            Console.WriteLine($"The mage has {mage.Mana} mana.");


            //Tools.ColorfulWriteLine(warrior.AbilityPoints.ToString(), ConsoleColor.DarkCyan);



        }
    }
}
