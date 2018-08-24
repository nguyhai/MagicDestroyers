using Enumerations;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Equipment.Armors.Light;
using MagicDestroyers.Equipment.Weapons.Blunt;
using MagicDestroyers.Interfaces;
using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    // You can implement as many interfaces ase you want, but you can only inherit from ONE class. 
    public class Mage: Spellcaster, ICalculator, ISpellcaster
    {
        private int _mana;
        private Spell _mySpell;

        public Spell MySpell
        {
            get
            {
                return _mySpell;
            }
            set
            {
                _mySpell = value;
            }
        }

        // Constants
        private const string DefaultName = "Bob";
        private const int DefaultLevel = 1;
        private const int DefaultHealthPoints = 80;
        private const int DefaultManaPoints = 10;
        private const Faction DefaultFaction = Faction.Spellcaster;

        private readonly ClothRobe DefaultBodyArmor = new ClothRobe();
        private readonly Staff DefaultWeapon = new Staff();

        private ClothRobe _bodyArmor;
        private Staff _weapon;
        
        public ClothRobe BodyArmor
        {
            get
            {
                return _bodyArmor;
            }
            set
            {
                _bodyArmor = value;
            }
        }

        public Staff Weapon
        {
            get
            {
                return _weapon;
            }
            set
            {
                _weapon = value;
            }
        }

        public int Mana
        {
            get
            {
                return _mana;
            }

            set
            {
                _mana = value;
            }
        }

        // Constructors
        public Mage()
            : this("Garen", 1)
        {
            // instantiating spell object
            MySpell = new Spell();
            Mana = 100;
        }

        public Mage(string name, int level)
            : this(name, level, DefaultHealthPoints, DefaultFaction)
        {
        }

        public Mage(string name, int level, int healthPoints, Faction faction)
        {
            Name = name;
            Level = level;
            HealthPoints = healthPoints;
            ManaPoints = DefaultManaPoints;
            Faction = faction;
            BodyArmor = DefaultBodyArmor;
            Weapon = DefaultWeapon;

            if (Faction == Faction.Spellcaster)
            {
                HealthPoints = 120;
            }
            else if (Faction == Faction.Spellcaster)
            {
                HealthPoints = 100;
            }

        }

        public void Fireball()
        {
            throw new NotImplementedException();
        }

        public void ArcaneWrath()
        {
            throw new NotImplementedException();
        }

        public void Meditation()
        {
            throw new NotImplementedException();
        }

        // Using override method here. We are overriding virual method in the base class. 
        public override void Move(int pauseAmount)
        {
            base.Move(pauseAmount);
            Console.WriteLine("I just moved 10 times, I am a mage");
        }

        // In the implementing class, it cares about HOW it happens, and this is where we put our implementation. 
        // It expects 2 numbers. The interface doesn't care about "How" this happens. It just care about telling the class to take the two numbers and do something with it (in this case, "Addition" as the interface name should define what it does). 
        public override void Addition(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            int modifiedSum = sum + 123;
            Console.WriteLine(modifiedSum - 123);
        }


        
        public void CastSpell(Warrior warrior)
        {
            // The warrior's healthpoints are subtracted by the spelldamage. 
            warrior.HealthPoints = warrior.HealthPoints - MySpell.Damage;
            _mana = Mana - MySpell.ManaCost;
        }
    }
}
