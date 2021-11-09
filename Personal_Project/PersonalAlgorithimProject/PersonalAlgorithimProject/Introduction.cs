using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace PersonalAlgorithimProject
{
    /// <summary>
    /// Create a menu instead of a whole class for the introduction to be better organized
    /// </summary>
    class Introduction
    {
        InventoryList List = new InventoryList();
        bool active = true;
        public void Intro() //Intro to the application
        {
            while (active == true) // loops until the 5th option is clicked
            {
                Console.WriteLine("Welcome to RPG Item Sorter: \n" +
                    "Pick from the following options to proceed\n");

                SelectOption(); 
                OptionSelected();
            }
        }

        public void SelectOption() // Ask the user what they want to do 
        {
            WriteLine("Option 1: See the current list"); //Shows the list items that currenlty inside
            WriteLine("Option 2: Add to the List"); //Add items to the list
            //WriteLine("Option 3: Organize in the list"); // Organize the list
            WriteLine("Option 3: Delete from the list"); //Delete items from the list
            WriteLine("Option 4: Exit the program"); //closes the program
        }

        public void OptionSelected() // Option menu set up
        {
            string choice;
            choice = ReadLine();

           // WriteLine(choice + " is the option you picked");

            switch (choice)
            {
                case "1": //shows list
                    WriteLine("Option 1 Selected\n");
                    List.PrintListName();
                    WriteLine("\n");
                    break;

                case "2": //adds item
                    WriteLine("Option 2 Selected\n");
                    List.itemAdded();
                    
                    break;

                //case "3": //organize items
                  //  WriteLine("Option1 3 Selected\n");
                    //break;

                case "3": // delete items
                    WriteLine("Option 3 Selected\n");
                    List.itemDelete();
                   
                    break;

                case "4": //exit program
                    WriteLine("Option 4 Selected\n");
                    active = false;
                    break;

            }
        }
    }
}
