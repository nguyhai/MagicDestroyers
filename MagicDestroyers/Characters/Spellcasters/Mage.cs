using Enumerations;
using MagicDestroyers.Equipment.Armors.Light;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Mage: Character
    {
        // Constants
        private const string DefaultName = "Bob";
        private const int DefaultLevel = 1;
        private const int DefaultHealthPoints = 120;
        private const int DefaultAbilityPoints = 10;
        private const Faction DefaultFaction = Faction.Spellcaster;

        private readonly ClothRobe DefaultBodyArmor = new ClothRobe();
        private readonly Staff DefaultWeapon = new Staff();

        private int _abilityPoints;
        private int _healthPoints;
        private int _level;

        private Faction _faction;
        private string _name;

        private ClothRobe _bodyArmor;
        private Staff _weapon;

        public int HealthPoints
        {
            get
            {
                return _healthPoints;
            }
            set
            {
                if (value >= 0)
                {
                    _healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("HealthPoints", $"Healthpoints cannot be set to a negative number for {_name}");
                }
            }
        }
         
        public int AbilityPoints
        {
            get
            {
                return _abilityPoints;
            }
            set
            {
                if (value >= 0)
                {
                    _abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $"Ability Points cannot be Negative or over 10 for {_name}");
                }
            }
        }

        public int Level
        {
            get
            {
                return _level;
            }
            set
            {
                if (value >= 0)
                {
                    _level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $"Level cannot be Negative for {_name}");
                }
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
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
        public Faction Faction
        {
            get
            {
                return _faction;
            }
            set
            {
                _faction = value;
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
            AbilityPoints = DefaultAbilityPoints;
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
