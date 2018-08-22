using Enumerations;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Necromancer : Spellcaster
    {
        // Constants
        private const string DefaultName = "Bob";
        private const int DefaultLevel = 1;
        private const int DefaultHealthPoints = 90;
        private const int DefaultManaPoints = 10;
        private const Faction DefaultFaction = Faction.Spellcaster;

        private readonly LightLeatherVest DefaultBodyArmor = new LightLeatherVest();
        private readonly Sword DefaultWeapon = new Sword();

        // Fields

        private LightLeatherVest _bodyArmor;
        private Sword _weapon;

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
