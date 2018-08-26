using Enumerations;
using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcasters;
using MagicDestroyers.Interfaces;
using System;
using System.Collections.Generic;

namespace MagicDestroyers
{
    class EntryPoint
    {
        static void Main()
        {
            Random rng = new Random();

            int currentMelee = 0;
            int currentSpellcaster = 0;

            bool gameOver = false;

            List<Character> characters = new List<Character>()
            {
                new Warrior(),
                //new Knight(),
                //new Assassin(),
                new Mage(),
                //new Necromancer(),
                //new Druid()
                new Mage(),
                new Mage(),
                new Mage(),
                new Warrior(),
                new Warrior(),

            
            };

            // Creating two lists for each team
            List<Melee> meleeTeam = new List<Melee>();
            List<Spellcaster> spellTeam = new List<Spellcaster>();

            foreach (var character in characters)
            {
                if (character is Melee)
                {
                    meleeTeam.Add((Melee)character);
                }
                else if(character is Spellcaster)
                {
                    spellTeam.Add((Spellcaster)character);
                }
            }

            while (!gameOver)
            {
                currentMelee = rng.Next(0, meleeTeam.Count);
                currentSpellcaster = rng.Next(0, spellTeam.Count);

                // 1. Take a random melee 
                // 2. Take a random spellcaster

                // 3. Melee attacks spellcaster
                spellTeam[currentSpellcaster].TakeDamage(meleeTeam[currentMelee].Attack(), meleeTeam[currentMelee].Name);

                if (!spellTeam[currentSpellcaster].IsAlive)
                {
                    meleeTeam[currentMelee].WonBattle();
                    spellTeam.Remove(spellTeam[currentSpellcaster]);
                    if (spellTeam.Count == 0)
                    {
                        Console.WriteLine("Melee Team wins!");
                        break;
                    }
                    else
                    {
                        currentSpellcaster = rng.Next(0, spellTeam.Count);
                    }
                }
                // 3.1 Check if character died and remove him from the team
                // 3.2 If dead, get another character from the team

                // 4. Spellcaster attacks melee
                meleeTeam[currentMelee].TakeDamage(spellTeam[currentSpellcaster].Attack(),spellTeam[currentSpellcaster].Name);

                if (!meleeTeam[currentMelee].IsAlive)
                {
                    spellTeam[currentSpellcaster].WonBattle();
                    meleeTeam.Remove(meleeTeam[currentMelee]);
                    if (meleeTeam.Count == 0)
                    {
                        Console.WriteLine("Spellcaster Team wins!");
                        break;
                    }
                    else
                    {
                        currentMelee = rng.Next(0, meleeTeam.Count);
                    }
                }

                // 4.1 Check if character died and remove him from the team
                // 4.2 If dead, get another character from the team

                // 5. If no characters are alive from either of the teams, gameOver = true

            }

        }

        // For the following, warrior uses Attack method (since we cannot access the warrior class directly). It goes to the Character class.
        // When it goes to the character class, it sees that the attack method is an abstract class. 
        // Because it is an abstract class, it will then look for the SPECIFIC IMPLEMENTATION in the derived class.
        // It will see the Strike() method and execute it. 
        // warrior.Attack(mage);
    }
}
