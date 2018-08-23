using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors.Leather
{
    public class LightLeatherVest : Leather
    {
        private const int DefaultArmorPoints = 5;

        // Constructors, 1 default and one that takes an argument. The default one will take DefaultArmorPoints
        // Using the this keyword, we are pulling the DefaultArmorPoints from the next constructor down the line. 
        // Remember, with the this keyword on constructors, you are CONSTRUCTOR CHAINING. Chaining allows us to get rid of redundant code
        // Designate the constructor that takes the greatest number of arguments as the master constructor and have its implementation perform the required validation logic.
        // The remaining constructors can use this keyword to FORWARD the incoming arguments to the master constructor and provide any additional parameters as necessary. 
        // In this way, we only need to worry about maintaining a single constructor for the entire class while the remaining constructors are empty.

        public LightLeatherVest()
            : this(DefaultArmorPoints)
        {

        }

        public LightLeatherVest(int armorPoints)
        {
            ArmorPoints = armorPoints;
        }
    }
}
