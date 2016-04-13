using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchAndBound
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> knapsackItemsList = new List<Item>()
            {
                new Item(1, 32, 727),
                new Item(2, 40, 763),
                new Item(3, 44, 60),
                new Item(4, 20, 606),
                new Item(5, 1,  45),
                new Item(6, 29, 370),
                new Item(7, 3,  414),
                new Item(8, 13, 880),
                new Item(9, 6,  133),
                new Item(10, 39, 820)
            };

            knapsackItemsList.Sort();
            foreach (Item i in knapsackItemsList)
            {
                Console.WriteLine(i.ToString());
            }    
        }

        
    }
}
