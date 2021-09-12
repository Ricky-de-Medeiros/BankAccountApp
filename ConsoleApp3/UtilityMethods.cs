using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    // A class to hold common functions
    static class UtilityMethods
    {
        // A method for text inputs 
        public static string ReadTextInput(string aMessage)
        {
            string returnValue;

            Console.WriteLine(aMessage);
            returnValue = Console.ReadLine();

            return returnValue;
        }
        // Overloaded method
        public static void ReadTextInput(string aMessage, ref string aReturnValue)
        {
            aReturnValue = ReadTextInput(aMessage);
        }

        // A method for numeric inputs
        public static int ReadNumericInput(string aMessage)
        {
            int returnValue;

            Console.WriteLine(aMessage);
            returnValue = Convert.ToInt32(Console.ReadLine());

            return returnValue;
        }
        // Overloaded Method
        public static void ReadNumericInput(string aMessage, ref string aReturnValue)
        {
            aReturnValue = ReadTextInput(aMessage);
        }

        public static void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press Any Key To Continue...");
            Console.ReadKey();
        }
    }
}
