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
        private int _healthPoints;
        private int _weight;
        protected int _age;
        private string _name;
        
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

        public int Weight
        {
            get
            {
                return _weight;
            }
            set
            {

                    _weight = value;

            }
        }

        public virtual int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 18 && value <= 45)
                {
                    _age = value;

                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Please use age between 18 and 45");
                }
            }
        }

        // With inheritance, it cant inherit constructors, but you can reuse them using the base keyword
        // When using base keyword, we'll get access to the constructors one level above the inherited class. 

        // This default constructor fixes the issues that happen if the derived class has multiple constructors
        public Character()
        {

        }

        public Character(int healthPoints, int weight, int age)
        {
            HealthPoints = healthPoints;
            Weight = weight;
            Age = age;
        }

        // The difference between the Base and This keyword. The base keyword allows us to access to ALL non-private members of the inherited class. This allows us to reuse constructors. 
        // This keyword gives us access to all members of our class. 

        // Virtual, changing the implementation of properties or methods in the derived class, this allows for us to etend the property or method. 
        // With properties, you can redefine the properties for validation

    }
}
