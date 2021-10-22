using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace PersonalAlgorithimProject
{
    class LootSorter : InventoryList //Program should help you create a list, sort, add, and delete your loot 
    {
        //Get from player
        public string itemName;
        public string itemRarity;

        //Name of the loot Color in THe Text to help tell what tier they are
        public string Exotic = "Exotic Loot";
        public string Legendary = "Legendary Loot";
        public string Rare= "Rare Loot";  //Strings are a place holder at the moment change later
        public string Uncommon = "Uncommon Loot";
        public string Common = "Common Loot";

        //Total number of each type of loot that you might have
        public int TotalLoot;
        public int TotalExotic;
        public int TotalLegendary; //Find a better way to organize the amount(int) of loot 
        public int TotalRare;
        public int TotalUncommon;
        public int TotalCommon;


        //Add a show list option

        //Move and organize the code better
        public void ListLoot()//Create a List of all the loot that the player has
        {
            // Make a list 
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Option 1: This options helps you create a list of the loot"); 
        }

        public void SortLoot() //Sort all the loot that was created with the list loot
        {
            //Have a way to sort the items
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("\nOption 2: This Option will allow the user to sort all the loot they have added"); 
        }

        public void AddLoot()
        {
            //Add to the list method
            ForegroundColor = ConsoleColor.Green;
            WriteLine("\nOption 3: This option will allow the user to add items to the list if its already created"); 
        }

        public void DeleteLoot() //Delete loot that you don't want in your inventory
        {
            //Delete from the list method
            ForegroundColor = ConsoleColor.Red;
            WriteLine("\nOption 4: This Option will allow the user to delete items that they have added to their list"); 
        }

    }
}
