using Enumerations;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior : Character
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

        //private int _height;
        //private int _weight;
        //private int _age;

        private int _abilityPoints;
        private int _healthPoints;
        private int _level;

        private Faction _faction;

        private Chainlink _bodyArmor;
        private Axe _weapon;

        // Properties ----------------------

        // Think of it like a barrier, so that the outside cant just go and change the value of _height directly. Get is Read, Set is Write
        // Do we always need to do this? No. Properties, usually for external. 
        // C Sharp auto creates backing fields if you use auto properties. 

        //public int HealthPoints
        //{
        //    get
        //    {
        //        return _healthPoints;
        //    }
        //    set
        //    {
        //        if (value >= 0)
        //        {
        //            _healthPoints = value;
        //        }
        //        else
        //        {
        //            throw new ArgumentOutOfRangeException("HealthPoints", $"Healthpoints cannot be set to a negative number for {_name}");
        //        }
        //    }
        //}


        public int AbilityPoints
        {
            get
            {
                return _abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 50)
                {
                    _abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $"Ability Points cannot be Negative or over 10 for {base.Name}");
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
                    throw new ArgumentOutOfRangeException(string.Empty, $"Level cannot be Negative for {base.Name}");
                }
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

        public Warrior(int healthPoints, int weight, int age)
            :base(healthPoints, weight, age)
        {

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
