using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FishariesIndexes
{
    public class Orders
    {
        private double price;
        private int quantity;
        private String fishType, sides, beverage;

        public Orders(double price, string fishType, string sides, int quantity, string beverage)
        {
            this.price = price;
            this.fishType = fishType;
            this.sides = sides;
            this.quantity = quantity;
            this.beverage = beverage;
        }

        public object this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return this.price;
                    case 1: return this.fishType;
                    case 2: return this.sides;
                    case 3: return this.quantity;
                    case 4: return this.beverage;
                    default: return null;

                }

            }
            set
            {
                //explicitly converting the original value to a string type
                switch (index)
                {
                    case 0: this.price = (double)(value); break;
                    case 1: this.fishType = (string)(value); break;
                    case 2: this.sides = (string)(value); break;
                    case 3: this.quantity = (int)(value); break;
                    case 4: this.beverage = (string)(value); break;
                }
            }
        }

        public object this[String attrName]
        {
            get
            {
                switch (attrName.ToLower())
                {
                    case "price": return this.price;
                    case "fishtype": return this.fishType;
                    case "sides": return this.sides;
                    case "quantity": return this.quantity;
                    case "beverage": return this.beverage;
                    default: return null;

                }
            }
            set
            {
                //explicitly converting the original value to a string type
                //using .ToLower() to return string in lowercase 
                switch (attrName.ToLower())
                {
                    case "price": this.price = (double)(value); break;
                    case "fishtype": this.fishType = (string)(value); break;
                    case "sides": this.sides = (string)(value); break;
                    case "quantity": this.quantity = (int)(value); break;
                    case "beverage": this.beverage = (string)(value); break;
                }
            }
        }
    }
}
