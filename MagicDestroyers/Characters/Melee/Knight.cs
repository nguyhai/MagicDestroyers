//using Enumerations;
//using MagicDestroyers.Equipment.Armors.Heavy;
//using MagicDestroyers.Equipment.Weapons.Blunt;
//using System;

//namespace MagicDestroyers.Characters.Melee
//{
//    public class Knight : Melee
//    {
//        // Constants
//        private const string DefaultName = "Bob";
//        private const int DefaultLevel = 1;
//        private const int DefaultHealthPoints = 160;
//        private const int DefaultAbilityPoints = 10;
//        private const Faction DefaultFaction = Faction.Melee;

//        private readonly Chainlink DefaultBodyArmor = new Chainlink();
//        private readonly Hammer DefaultWeapon = new Hammer();

//        // Constructors -----------------------
//        public Knight()
//            : this(DefaultName, DefaultLevel)
//        {
//        }

//        public Knight(string name, int level)
//            : this(name, level, DefaultHealthPoints, DefaultFaction)
//        {
//        }

//        public Knight(string name, int level, int healthPoints, Faction faction)
//        {
//            Name = name;
//            Level = level;
//            HealthPoints = healthPoints;
//            AbilityPoints = DefaultAbilityPoints;
//            Faction = faction;
//            BodyArmor = DefaultBodyArmor;
//            Weapon = DefaultWeapon;

//        }

//        public void HolyBlow()
//        {
//            throw new NotImplementedException();
//        }

//        public void PurifySoul()
//        {
//            throw new NotImplementedException();
//        }

//        public void RighteousWings()
//        {
//            throw new NotImplementedException();
//        }

//        public override void Attack()
//        {
//            HolyBlow();
//        }

//        public override void SpecialAttack()
//        {
//            PurifySoul();
//        }

//        public override void Defend()
//        {
//            RighteousWings();
//        }
//    }
//}
