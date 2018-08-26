using Enumerations;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;
using MagicDestroyers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters
{
    public abstract class Character: IAttack, IDefend
    {
        // Protected access modifier, used to share between base and derived classes. Not for fields, those should be private.
        // Common fields between the characters - This is what we are extacting from the classes we have and putting it here because all the characters have it in common
        private Faction _faction;
        private string _name;
        private int _level;
        private int _healthPoints;
        private bool _isAlive;
        private int _scores;

        private Armor _bodyArmor;
        private Weapon _weapon;

        public Armor BodyArmor
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

        public Weapon Weapon
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

        // Any validation here will be the default. If you have different validation for properties (like health for mages), that needs to be in that specific class and overrided. 

        public int Scores
        {
            get
            {
                return _scores;
            }
            set
            {
                _scores = value;
            }
        }
        public bool IsAlive
        {
            get
            {
                return _isAlive;
            }
            set
            {
                _isAlive = value;
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

        public virtual int HealthPoints
        {
            get {
                return _healthPoints;
            }
            set
            {
                _healthPoints = value;
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
                   throw new ArgumentOutOfRangeException(string.Empty, $"Level cannot be Negative for {Name}");
                }
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

        // With inheritance, it cant inherit constructors, but you can reuse them using the base keyword
        // When using base keyword, we'll get access to the constructors one level above the inherited class. 

        // This default constructor fixes the issues that happen if the derived class has multiple constructors. This is needed if your derived class has more than one constructor
        public Character()
        {

        }

        public Character(int healthPoints)
        {
            HealthPoints = healthPoints;

        }

        public Character(int level, int healthPoints, string name, Faction faction)
        {
            Level = level;
            HealthPoints = HealthPoints;
            Name = name;
            Faction = faction;
        }

        // Using virtiual methods and properties
        public virtual void Move(int pauseAmount)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("I am moving");
                Thread.Sleep(pauseAmount);
            }
        }

        public void Greetings()
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(int damage, string attackerName)
        {
            // We only want to apply damage if the damage is higher than current defense of the character
            if (Defend() < damage)
            {
                _healthPoints = _healthPoints - damage + Defend();

                if (_healthPoints <= 0)
                {
                    _isAlive = false;
                }
            }
            else
            {
                Console.WriteLine("No damage dealt!");
            }

            // If character is dead....
            if (!IsAlive)
            {
                Console.WriteLine($"{_name} received {damage} from {attackerName} damage, and is now dead!");
            }
            else
            {
                Console.WriteLine($"{_name} received {damage} damage from {attackerName}, and now has {_healthPoints} healthpoints!");
            }
        }

        public void WonBattle()
        {
            _scores++;
            // Every 10 scores, the character levels up
            if(_scores % 10 == 0)
            {
                _level++;
            }
        }

        // If we use virtual, we would need default method, which won't work because each class has different types of attacks. In this case, we will use abstract classes for the methods. 

        public abstract int Attack();

        public abstract int SpecialAttack();

        public abstract int Defend();

        // ----------------------------------------------------------------------------------------------------------------------------------
        // When a class inherits from another class, it inherits all it's members, this includes fields, properties, and methods. It cant inherit constructors, but it can REUSE them using the base keyword.  

        // The difference between the Base and This keyword. The base keyword allows us to access to ALL non-private members of the inherited class. This allows us to reuse constructors. 
        // Does the same thing as This, but gives access to the members of the inherited class only
        // The This keyword gives us access to all members of our class. 

        // Virtual, changing the implementation of properties or methods in the derived class, this allows for us to etend the property or method. 
        // With properties, you can redefine the properties for validation

        // Abstraction-----------------------------------------------------------------------------------------------------------------------
        // The main purpose is to reudce the complexity of your code. Focus only on relevant issues of the program. 
        // Hide info from the client and show only necessary details.
        // Abstraction is one of the principle of object oriented programming. 
        // It is used to display only necessary and essential features of an object to ouside the world.
        // Means displaying what is necessary and encapsulate the unnecessary things to outside the world.Hiding can be achieved by using "private" access modifiers. 

        // Can use abstract classes and interfaces to achieve this. 
        // For example, having an interface will a few properties, will force us to implement them and make them non-optional.
        // Lets say you make an IMakeFire interface. You just need to know that it makes the fire, not how exactly it is done. 
        // Any class that implements this interface will know how to make fire. 

        // Interfaces------------------------------------------------------------------------------------------------------------------------
        // An interface contains definitions for a group of related functionalities that a class or a struct can implement.
        // By using interfaces, you can, for example, include behavior from multiple sources in a class. ... 
        // In that way, an interface in C# is similar to an abstract class in which all the methods are abstract.
        // The interface defines only the signature.
        // However, a class or struct can implement multiple interfaces, but a class can inherit only a single class, abstract or not. 
        // Therefore, by using interfaces, you can include behavior from multiple sources in a class.
        // So basically, if you have an interface, with properties and methods, any class that implements the interface will be foreced to use the members in the interface. 
        // Interfaces can contain methods, properties, events, indexers, or any combination of those four member types.

        // With an Interface, the Interface provides the "What" part, and the implementing class provides the "How" part



    }
}
