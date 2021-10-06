using System;

namespace PersonalAlgorithimProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Organize Later
            LootSorter sort = new LootSorter();
            Introduction intro = new Introduction();
            intro.Intro();
            
            //Get rid of all these and only call Intro/Menu (Change Later)
            sort.ListLoot();
            sort.SortLoot();
            sort.AddLoot();
            sort.DeleteLoot();
        }
    }
}
