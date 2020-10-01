using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Cafe
{
    class MenuItem
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string MealDesc { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }

        public MenuItem (int mealNumber, string mealName, string mealDesc, string ingredients, double price)
        {
            MealNumber = mealNumber;
            mealName = mealName;
            mealDesc = mealDesc;
            Ingredients = ingredients;
            Price = price;
        }
    }
}
