using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using static System.Console;

namespace Fisher_Yates_Practice
{
    class ArrayList
    {

        private static Random rng = new Random();
        List<int> list1 = new List<int>() { 1, 2, 3, 4, 5 }; // List Shuffle this
        

        public void PrintListName() //Displays the order that the names need to be in
        {
           foreach (var value in list1)
            {
                WriteLine(value);
            }
        }

        

    public void RandomPrintName() // Displays the random Fisher_Yates algorithim to the array
        {
           
        }

        public void Randomizer<T>(this IList<T> list) //Method to randomize the array
        {
            int n = list1.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            foreach (var value in list1)
            {
                WriteLine(value);
            }
        }
    }
}
