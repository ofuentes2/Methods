// Programmer: Omar Fuentes
// Project: Week 4-2
// Date: 02/05/2020
// Description: Working with Methods

using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user input their name.
            Console.WriteLine("Please enter your name:");

            // To handle input errors. 
            try
            {              
                // Read input from user.
                string name = Console.ReadLine();                
                
                    // Method call and user's name.
                    User_Name(name);
            }
            catch
            {
                // Display error message if wrong input is entered.
                Console.WriteLine("You have entered an invalid input!");
            }
        }

        // Customer method called User_Name
        private static string User_Name(string get_name)
        {
            // Extra space
            Console.WriteLine("");
            // Display Hello and user's name in a message.
            Console.Write("Hello " + get_name + "!");

            // Return the value.
            return get_name;
        }
    }
}
        
    

