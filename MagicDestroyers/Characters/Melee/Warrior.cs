using Enumerations;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Sharp;
using MagicDestroyers.Interfaces;
using System;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior : Melee, ICalculator // Add comma, add interfaces
    {
        // The This keyword, lets us have access to everything in the class. It points to that SPECIFIC INSTANCE of that class. It's main purpose is to help distinguist between objects that have the same name. 
        // Backing fields. Private just means it is only accessible within this class and no where else. 
        // Access modifiers, Internal limits the access to the project in which the project is contained. 
        // Protected limits it so that members of a class visibile only to classes that inherit this class
        // Protected Internal is a mix of both protected and internal
        // Static - shared between the instance, accessed from the class. Static variables, static methods, static classes. 

        // Constants - Leaving some of the constants here, every character has different constants


        // We cant use const for objects, so in this case, we can use the readonly keyword
        private readonly Chainlink DefaultBodyArmor = new Chainlink();
        private readonly Axe DefaultWeapon = new Axe();

        // Think of it like a barrier, so that the outside cant just go and change the value of _height directly. Get is Read, Set is Write
        // Do we always need to do this? No. Properties, usually for external. 
        // C Sharp auto creates backing fields if you use auto properties. 

        // Constructors -----------------------------------

        // EXAMPLES
        //public Warrior()
        //    : this(170, 70) // This gives values, and then executes the constructors. 
        //{
        //    //Weapon = new Axe(); // This is how we equip our weapon. We instantiate the object within our constructor, giving our character their weapon and whatever stats it has on it. 

        public Warrior()
            :this(Consts.DefaultName, Consts.DefaultLevel)
        {

        }
        // Constructor chaining here, we take two params, then push it all to the constructor with he most arguments using the this keyword
        public Warrior(string name, int level)
            :this(name, level, Consts.DefaultHealthPoints, Consts.DefaultFaction)
        {
        }

        public Warrior(string name, int level, int healthPoints, Faction faction)
        {
            Name = name;
            Level = level;
            HealthPoints = healthPoints;
            AbilityPoints = Consts.DefaultAbilityPoints;
            Faction = Consts.DefaultFaction;

            BodyArmor = DefaultBodyArmor;
            Weapon = DefaultWeapon;

            IsAlive = true;
            Scores = 0;
        }

        // Methods ----------------------------------------

        public int Strike()
        {
            return Weapon.Damage + 10;
        }

        public int Execute()
        {
            return Weapon.Damage + 15;
        }

        public int SkinHarden()
        {
            return BodyArmor.ArmorPoints + 5;
        }

        // Using the override keyword, we are overriding a virtual method here
        public override void Move(int pauseAmount)
        {
            base.Move(pauseAmount);
            Console.WriteLine("I just moved 10 times, I am a warrior");
        }

        // These next 3 are the implemented abstract class. 
        public override int Attack()
        {
            return Strike();
        }

        public override int SpecialAttack()
        {
            return Execute();
        }

        public override int Defend()
        {
            return SkinHarden();
        }

        // Using for example purposes
        public void Addition(int firstNumber, int secondNumber)
        {
            throw new NotImplementedException();
        }
    }
}
