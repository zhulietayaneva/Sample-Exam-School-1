using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnishingEx
{
    public class Chair : Furniture
    {
        public string Color { get; private set; }
        public Chair(string color, double price, double discountPercent) : base("Chair", price, 6, discountPercent)
        {
            this.Color = color;
            
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override string GetColor()
        {
            return this.Color;
        }
    }
}
