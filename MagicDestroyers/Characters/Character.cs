using Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters
{
    public class Character
    {
        // Common fields between the characters - This is what we are extacting from the classes we have and putting it here because all the characters have it in common
        private Faction _faction;
        private string _name;
        private int _level;
        private int _healthPoints;
        
        public virtual void Move(int pauseAmount)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("I am moving");
                Thread.Sleep(pauseAmount);
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

        public int HealthPoints
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

        // This default constructor fixes the issues that happen if the derived class has multiple constructors
        public Character()
        {

        }

        public Character(int healthPoints)
        {
            HealthPoints = healthPoints;

        }

        // ----------------------------------------------------------------------------------------------------------------------------------
        // The difference between the Base and This keyword. The base keyword allows us to access to ALL non-private members of the inherited class. This allows us to reuse constructors. 
        // This keyword gives us access to all members of our class. 

        // Virtual, changing the implementation of properties or methods in the derived class, this allows for us to etend the property or method. 
        // With properties, you can redefine the properties for validation

    }
}
