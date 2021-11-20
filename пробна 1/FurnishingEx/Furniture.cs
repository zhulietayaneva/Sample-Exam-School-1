using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnishingEx
{
  public class Furniture
    {

        public string Name { get; private set; }

        public double Price { get; private set; }

        public int SetCount { get; set; }

        public int Amount { get; set; }

        public double DiscountPercent { get; private set; }


        public Furniture(string name, double price, int setCount, double discountPercent)
        {
            this.Name = name;
            this.Price = price;
            this.SetCount = setCount;
            this.DiscountPercent = discountPercent;

        }


        public virtual string GetColor()
        {
            return "";
        }
              


        public virtual double Cost(int count)
        {
            return 0;
        }

        public int CompareTo(Furniture f)
        {
            return 0;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
