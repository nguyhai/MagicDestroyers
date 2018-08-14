using Enumerations;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior : Melee
    {
        // The This keyword, lets us have access to everything in the class. It points to that SPECIFIC INSTANCE of that class. It's main purpose is to help distinguist between objects that have the same name. 
        // Backing fields. Private just means it is only accessible within this class and no where else. 
        // Access modifiers, Internal limits the access to the project in which the project is contained. 
        // Protected limits it so that members of a class visibile only to classes that inherit this class
        // Protected Internal is a mix of both protected and internal
        // Static - shared between the instance, accessed from the class. Static variables, static methods, static classes. 

        // Constants
        private const string DefaultName = "Bob";
        private const int DefaultLevel = 1;
        private const int DefaultHealthPoints = 120;
        private const int DefaultAbilityPoints = 10;
        private const Faction DefaultFaction = Faction.Melee;

        // We cant use const for objects, so in this case, we can use the readonly keyword
        private readonly Chainlink DefaultBodyArmor = new Chainlink();
        private readonly Axe DefaultWeapon = new Axe();


        private Chainlink _bodyArmor;
        private Axe _weapon;

        // Properties ----------------------

        // Think of it like a barrier, so that the outside cant just go and change the value of _height directly. Get is Read, Set is Write
        // Do we always need to do this? No. Properties, usually for external. 
        // C Sharp auto creates backing fields if you use auto properties. 



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

        public Axe Weapon
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


        // Constructors -----------------------------------

        // EXAMPLES
        //public Warrior()
        //    : this(170, 70) // This gives values, and then executes the constructors. 
        //{
        //    //Weapon = new Axe(); // This is how we equip our weapon. We instantiate the object within our constructor, giving our character their weapon and whatever stats it has on it. 

        public Warrior()
            :this(DefaultName, DefaultLevel)
        {
        }

        public Warrior(string name, int level)
            :this(name, level, DefaultHealthPoints, DefaultFaction)
        {
        }

        public Warrior(string name, int level, int healthPoints, Faction faction)
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


        // Methods ----------------------------------------

        public void Strike()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void SkinHarden()
        {
            throw new NotImplementedException();
        }
        public override void Move(int pauseAmount)
        {
            base.Move(pauseAmount);
            Console.WriteLine("I just moved 10 times, I am a warrior");
        }
    }
}
