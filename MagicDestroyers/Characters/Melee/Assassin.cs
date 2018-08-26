
//using Enumerations;
//using MagicDestroyers.Equipment.Armors.Leather;
//using MagicDestroyers.Equipment.Weapons.Sharp;
//using System;

//namespace MagicDestroyers.Characters.Melee
//{
//    public class Assassin : Melee
//    {
//        private const string DefaultName = "Bob";
//        private const int DefaultLevel = 1;
//        private const int DefaultHealthPoints = 100;
//        private const int DefaultAbilityPoints = 10;
//        private const Faction DefaultFaction = Faction.Melee;

//        private readonly LightLeatherVest DefaultBodyArmor = new LightLeatherVest();
//        private readonly Sword DefaultWeapon = new Sword();

//        // Constructors

//        public Assassin()
//            : this(DefaultName, DefaultLevel)
//        {
//        }

//        public Assassin(string name, int level)
//            : this(name, level, DefaultHealthPoints, DefaultFaction)
//        {
//        }

//        public Assassin(string name, int level, int healthPoints, Faction faction)
//        {
//            Name = name;
//            Level = level;
//            HealthPoints = healthPoints;
//            AbilityPoints = DefaultAbilityPoints;
//            Faction = faction;
//            BodyArmor = DefaultBodyArmor;
//            Weapon = DefaultWeapon;

//        }

//        public void Raze()
//        {
//            throw new NotImplementedException();
//        }

//        public void BleedToDeath()
//        {
//            throw new NotImplementedException();
//        }

//        public void Survival()
//        {
//            throw new NotImplementedException();
//        }

//        public override void Attack()
//        {
//            Raze();
//        }

//        public override void SpecialAttack()
//        {
//            BleedToDeath();
//        }

//        public override void Defend()
//        {
//            Survival();
//        }
//    }
//}
