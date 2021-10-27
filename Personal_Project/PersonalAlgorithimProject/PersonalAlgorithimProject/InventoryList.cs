using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace PersonalAlgorithimProject
{
    class InventoryList : itemsTest
    {
        //AddItem add = new AddItem();

        public List<itemsTest> itemList = new List<itemsTest>(); // { "item1", "item2", "item3", "item4", "item5" };

        
        public InventoryList()
        {
            
        }

       
        public void PrintListName() //shows the list 
        {
            
            foreach(itemsTest xitemsTest in itemList)
            {
                WriteLine(xitemsTest);
                
            }
        }

        public void testList() //testing the list 
        {
            itemList.Add(new itemsTest() { ItemName = "item1", ItemType = "exotic" });
            itemList.Add(new itemsTest() { ItemName = "item2", ItemType = "legendary" });
            itemList.Add(new itemsTest() { ItemName = "item3", ItemType = "rare" });
            itemList.Add(new itemsTest() { ItemName = "item4", ItemType = "uncommon" });
            itemList.Add(new itemsTest() { ItemName = "item5", ItemType = "common" });
        }
        public void itemAdded() // item added 
        {
           
            
            WriteLine("Add a name of the Item");
            string nameItem = ReadLine();

            WriteLine("What rarity is the item");
            string typeItem = ReadLine(); 

            
            
            itemList.Add(new itemsTest() { ItemName = nameItem, ItemType = typeItem });

            WriteLine("New Item Added\n");

            foreach (itemsTest xitemsTest in itemList)
            {
                WriteLine(xitemsTest);

            }
            WriteLine("\n");

        }

        public void itemDelete()
        {
            
            //method from delete class
        }



        public void RarityPicker()
        {
            WriteLine("What type of rarity is the item of choice");
            string rarityPick = ReadLine();
            string typeItem; 

            switch (rarityPick)
            {
                case "1": //Common Item
                    typeItem = "Common";
                break;

                case "2": //Uncommon Item
                    typeItem = "Uncommon";
                    typeItem = ItemType;
                    break;

                case "3": //Rare Item
                    typeItem = "Rare";
                    break;

                case "4": //Legendary Item
                    typeItem = "Legendary";
                    break;

                case "5": //Exotic Item
                    typeItem = "Exotic";
                    break;
            }



        }
    }
}
