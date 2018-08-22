using Enumerations;
using MagicDestroyers.Equipment.Armors.Light;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Mage: Spellcaster
    {
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

        // Constructors
        public Mage()
            : this("Garen", 1)
        {
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


    }
}
