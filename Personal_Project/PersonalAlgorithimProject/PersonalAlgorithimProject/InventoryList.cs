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
      
        
        public void PrintListName() //shows the list 
        {
            testList();
            foreach(itemsTest xitemsTest in itemList)
            {
                WriteLine(xitemsTest);
                
            }
        }

        public void testList()
        {
            itemList.Add(new itemsTest() { ItemName = "item1", ItemType = "exotic" });
            itemList.Add(new itemsTest() { ItemName = "item2", ItemType = "legendary" });
            itemList.Add(new itemsTest() { ItemName = "item3", ItemType = "rare" });
            itemList.Add(new itemsTest() { ItemName = "item4", ItemType = "uncommon" });
            itemList.Add(new itemsTest() { ItemName = "item5", ItemType = "common" });
        }
        public void itemAdded()
        {
            
            //add.AddingItems(); //method from add class
        }

        public void itemDelete()
        {
            //itemList.Remove("item5");
            //method from delete class
        }

    }
}
