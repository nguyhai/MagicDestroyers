using Enumerations;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Necromancer
    {
        // Constants
        private const string DefaultName = "Bob";
        private const int DefaultLevel = 1;
        private const int DefaultHealthPoints = 120;
        private const int DefaultAbilityPoints = 10;
        private const Faction DefaultFaction = Faction.Spellcaster;

        private readonly LightLeatherVest DefaultBodyArmor = new LightLeatherVest();
        private readonly Sword DefaultWeapon = new Sword();

        // Fields

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

        // Constructor

        public Necromancer()
             : this(DefaultName, DefaultLevel)
        {
        }

        public Necromancer(string name, int level)
            : this(name, level, DefaultHealthPoints, DefaultFaction)
        {
        }

        public Necromancer(string name, int level, int healthPoints, Faction faction)
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
        public void ShadowRage()
        {
            throw new NotImplementedException();
        }

        public void VampireTouch()
        {
            throw new NotImplementedException();
        }

        public void BoneShield()
        {
            throw new NotImplementedException();
        }
    }
}
