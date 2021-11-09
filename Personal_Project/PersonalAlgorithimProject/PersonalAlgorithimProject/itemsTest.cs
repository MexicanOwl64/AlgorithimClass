using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace PersonalAlgorithimProject
{
    class itemsTest
    {
        
            public string ItemName { get; set; } //Name of the list 
            public string ItemType { get; set; } // Type of Item

            public int placeItem { get; set; } //gets the place holder to delete items

        public override string ToString()
        {
            return "Item Place: " + placeItem + "  Item Name: " + ItemName + "   Type: " + ItemType;
        }
        public override bool Equals(object obj) //checks the naming convention of the list
        {
            if (obj == null) return false;
            itemsTest objAsPart = obj as itemsTest;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }

        public override int GetHashCode()
        {
            return placeItem;
        }
        public bool Equals(itemsTest other) // returns the item 
        {
            if (other == null) return false;
            return (this.ItemType.Equals(other.ItemName));
        }

       public enum itemType
        {
            Common,
            Uncommon,
            Rare,
            Legendary,
            Exotic
        }


    }
}
