using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MagicDestroyers
{
    public static class Tools
    {
        // Static classes can only have static members. Also known as a singleton class. We can access variables and methods without instantiating the class. 
        // CORRECTION - Static classes are similar but not equal to singleton classes. Singleton classes allow the instantiation of one object. 

        public static void ColorfulWriteLine(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();


            // Create list of images.

            List<string> images = new List<string>();
            images.Add("Stuff");


        }
    }

}