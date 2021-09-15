using System;

namespace ConstantMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Items i = new Items();
            i.ConstantExample();
            i.LinearExample();
            i.QuadraticExample();
        }

        class Items
        {

            public void ConstantExample() //An example of Constant for O(1)
            {
                int x = 20 + 1 - 4; // O(1)
                
                Console.WriteLine(x); // O{1}

                //total Time = O(1) + O(1) 
                //which total time is still O(1) since the constants are dropped. 
            }

            public void LinearExample()
            {
                int LinearList = 10;

                int y = 4 + 2 + 7; // O(1) 

                for (int i = 0; i < LinearList; i++) //O(N)
                {

                    Console.WriteLine("Chocolate"); //O(1)
                }

                //Total Time = O(1) + O(N)  + O(1) = O(N)
                //Since we drop the low order terms than this would O(N)
            }

            public void QuadraticExample()
            {
                int start = 0; //O(1)

                while (start < 10) //(ON)
                {
                    for (int i = 0; i < start; i++ ) // O(N)
                    {
                        for (int f = 0; f < start; f++) // O(N)
                        {
                            Console.WriteLine(start); // O(1)
                        }
                      
                    }
                    start++;
                }
                //Total Time = O(1) + O(N) + O(N) + O(N)
                //Since there are mutliple statements of O(N) total time equals O(N) + O(N) which would make O(N2)
            }
        }
    }
}
