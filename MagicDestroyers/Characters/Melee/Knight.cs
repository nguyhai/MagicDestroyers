using Enumerations;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;

namespace MagicDestroyers.Characters.Melee
{
    public class Knight
    {
        // Constants
        private const string DefaultName = "Bob";
        private const int DefaultLevel = 1;
        private const int DefaultHealthPoints = 120;
        private const int DefaultAbilityPoints = 10;
        private const Faction DefaultFaction = Faction.Melee;

        private readonly Chainlink DefaultBodyArmor = new Chainlink();
        private readonly Hammer DefaultWeapon = new Hammer();

        private int _abilityPoints;
        private int _healthPoints;
        private int _level;

        private Faction _faction;
        private string _name;

        private Chainlink _bodyArmor;
        private Hammer _weapon;


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

        public Chainlink BodyArmor
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

        public Hammer Weapon
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

        // Constructors -----------------------
        public Knight()
            : this(DefaultName, DefaultLevel)
        {
        }

        public Knight(string name, int level)
            : this(name, level, DefaultHealthPoints, DefaultFaction)
        {
        }

        public Knight(string name, int level, int healthPoints, Faction faction)
        {
            Name = name;
            Level = level;
            HealthPoints = healthPoints;
            AbilityPoints = DefaultAbilityPoints;
            Faction = faction;
            BodyArmor = DefaultBodyArmor;
            Weapon = DefaultWeapon;

            if (Faction == Faction.Melee)
            {
                HealthPoints = 120;
            }
            else if (Faction == Faction.Melee)
            {
                HealthPoints = 100;
            }
        }

        public void HolyBlow()
        {
            throw new NotImplementedException();
        }

        public void PurifySoul()
        {
            throw new NotImplementedException();
        }

        public void RighteousWings()
        {
            throw new NotImplementedException();
        }
    }
}
