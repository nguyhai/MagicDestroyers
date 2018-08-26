//using Enumerations;
//using MagicDestroyers.Equipment.Armors.Leather;
//using MagicDestroyers.Equipment.Weapons.Blunt;
//using System;

//namespace MagicDestroyers.Characters.Spellcasters
//{
//    public class Druid : Spellcaster
//    {
//        // Constants
//        private const string DefaultName = "Bob";
//        private const int DefaultLevel = 1;
//        private const int DefaultHealthPoints = 100;
//        private const int DefaultManaPoints = 10;
//        private const Faction DefaultFaction = Faction.Spellcaster;

//        private readonly LightLeatherVest DefaultBodyArmor = new LightLeatherVest();
//        private readonly Staff DefaultWeapon = new Staff();

//        // Constructors

//        public Druid()
//            : this(DefaultName, DefaultLevel)
//        {
//        }

//        public Druid(string name, int level)
//            : this(name, level, DefaultHealthPoints, DefaultFaction)
//        {
//        }

//        public Druid(string name, int level, int healthPoints, Faction faction)
//        {
//            Name = name;
//            Level = level;
//            HealthPoints = healthPoints;
//            ManaPoints = DefaultManaPoints;
//            Faction = faction;
//            BodyArmor = DefaultBodyArmor;
//            Weapon = DefaultWeapon;

//        }

//        public void Moonfire()
//        {
//            throw new NotImplementedException();
//        }

//        public void Starburst()
//        {
//            throw new NotImplementedException();
//        }

//        public void OneWithTheNature()
//        {
//            throw new NotImplementedException();
//        }

//        public override void Attack()
//        {
//            Moonfire();
//        }

//        public override void SpecialAttack()
//        {
//            Starburst();
//        }

//        public override void Defend()
//        {
//            OneWithTheNature();
//        }
//    }
//}
