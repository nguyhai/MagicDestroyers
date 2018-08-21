
using Enumerations;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters.Melee
{
    public class Assassin : Melee
    {
        private const string DefaultName = "Bob";
        private const int DefaultLevel = 1;
        private const int DefaultHealthPoints = 120;
        private const int DefaultAbilityPoints = 10;
        private const Faction DefaultFaction = Faction.Melee;

        private readonly LightLeatherVest DefaultBodyArmor = new LightLeatherVest();
        private readonly Sword DefaultWeapon = new Sword();

        private int _height;
        private int _weight;
        private int _abilityPoints;
        private int _healthPoints;
        private int _level;
        private Faction _faction;
        private string _name;
        private LightLeatherVest _bodyArmor;
        private Sword _weapon;

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

        public LightLeatherVest BodyArmor
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

        public Sword Weapon
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

        public Assassin()
            : this(DefaultName, DefaultLevel)
        {
        }

        public Assassin(string name, int level)
            : this(name, level, DefaultHealthPoints, DefaultFaction)
        {
        }

        public Assassin(string name, int level, int healthPoints, Faction faction)
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

        public void Raze()
        {
            throw new NotImplementedException();
        }

        public void BleedToDeath()
        {
            throw new NotImplementedException();
        }

        public void Survival()
        {
            throw new NotImplementedException();
        }
    }
}
