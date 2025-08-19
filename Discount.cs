using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project
{
    internal abstract class Discount
    {
        public string Name { get; set; }
        public abstract decimal CalculateDiscount(decimal price, int quantity);
    }
    internal class PercentageDiscount : Discount
    {
        public decimal Percentage { get; set; }

        public PercentageDiscount(decimal percentage) 
        {
            Name = "Percentage Discount";
            Percentage = percentage;
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * quantity * (Percentage / 100);
        }
    }
    internal class FlatDiscount : Discount
    {
        public decimal Flat { get; set; }

        public FlatDiscount(decimal flat) 
        {
            Name = "Flat Discount";
            Flat = flat;
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return Flat * Math.Min(quantity, 1);
        }
    }
    internal class BuyOneGetOneDiscount : PercentageDiscount
    {
        public BuyOneGetOneDiscount() : base(50)
        {
            Name = "Buy One Get One Discount";
        }
    }
}
