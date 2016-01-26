using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class UI
    {

        ///Private Variables -  No need to local variables, so there are no private 
        /// variabel declarations for this class.
        

        ///Properties - Since there are no local variables, there is no need for 
        ///public properties, so I dont need that section either. 
       

        ///Public methods - me will some of these!
        

        //This will print the manu to the screen, and await a valid input
        //from the user.  Once the input is valid, it will return the 
        //number that they selected. 
        public int GetUserInput()
        {
            //Print the Menu
            this.printMenu();

            //Accecpt user input from the terminal.  Whatever they type will come
            //back as a sting once they push enter on the keyboard.
            String input = Console.ReadLine();

            //while the input is not valid.
            while(input != "1" && input != "2")
            {

                Console.WriteLine("That is not a valid entry.");
                Console.WriteLine("Please make a valid choice.");
                Console.WriteLine();
                //Reprint the menu for the user. 
                this.printMenu();
                //Re-Fetch the user input from the console
                input = Console.ReadLine();
            }

            //I know since we are out fo the while loop that it must be either a 
            //one or a two, so there is no need for me to use a try / catch here.
            //I could, but it should NEVER hit the catch.
            return Int32.Parse(input);
        }
        
        //Take in a string that we would like to output to the screen
        //I realise that this will be about the same as just using a 
        //Console.WriteLine, but by defining the here, we could 
        //replace this class with a web one that might be more involved
        //without ever having to tourch the other classes of the program.
        public void PrintAllOutput(string allOutput)
        {
            Console.WriteLine(allOutput);
        }

        //This is just a private method to print the Menu.  It will probably 
        //happen quite a bit, so it make sense that it is in a method. 
        private void printMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print the List");
            Console.WriteLine("2. Exit");
        }

        ///Constructors -  No need for any constructor either.  We will
        ///just use the auctomatic defaul one is provided to us. 
        ///We can't see it, but trust me, it's available.














    }
}
