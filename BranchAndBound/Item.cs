using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchAndBound
{
    public class Item : IComparable<Item>
    {
        public int ID { get; set; }
        public int Weight { get; set; }
        public int Profit { get; set; }

        public decimal Efficiency { get; set; }

        public Item(int id, int weight, int profit)
        {
            this.ID = id;
            this.Profit = profit;
            this.Weight = weight;
            this.Efficiency = Convert.ToDecimal(profit)/Convert.ToDecimal(weight);
        }

        public int CompareTo(Item other)
        {
            if (this.Profit > other.Profit)
                return -1;
            else
            {
                return 1;
            }

        }

        public override string ToString()
        {
            return $"Item Id: {this.ID}, Weight: {this.Weight}, Profit: {this.Profit}, Efficiency: {this.Efficiency}";
        }
    }
}
