using Enumerations;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Druid : Spellcaster
    {
        // Constants
        private const string DefaultName = "Bob";
        private const int DefaultLevel = 1;
        private const int DefaultHealthPoints = 100;
        private const int DefaultManaPoints = 10;
        private const Faction DefaultFaction = Faction.Spellcaster;

        private readonly LightLeatherVest DefaultBodyArmor = new LightLeatherVest();
        private readonly Staff DefaultWeapon = new Staff();

        private LightLeatherVest _bodyArmor;
        private Staff _weapon;

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

        public Druid()
            : this(DefaultName, DefaultLevel)
        {
        }

        public Druid(string name, int level)
            : this(name, level, DefaultHealthPoints, DefaultFaction)
        {
        }

        public Druid(string name, int level, int healthPoints, Faction faction)
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

        public void Moonfire()
        {
            throw new NotImplementedException();
        }

        public void Starburst()
        {
            throw new NotImplementedException();
        }

        public void OneWithTheNature()
        {
            throw new NotImplementedException();
        }
    }
}
