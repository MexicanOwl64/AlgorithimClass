using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace PersonalAlgorithimProject
{
    class AddItem : InventoryList
    {
        public void AddingItems()
        {
            WriteLine("Add a name of the Item");
            string nameItem = ReadLine();

            WriteLine("What rarity is the item");
            string typeItem = ReadLine();

            itemList.Add(new itemsTest() { ItemName = nameItem, ItemType = typeItem });
        }

    }
}
