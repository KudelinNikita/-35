using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Консоль_35
{
    internal abstract class Dish
    {
        string name;
        int price;
        int calories;
        int preparation_time;

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int Calories { get => calories; set => calories = value; }
        public int Preparation_time { get => preparation_time; set => preparation_time = value; }
        public Dish(string name, int price,int calories, int preparation_time)
        {
            Name = name;
            Price = price;
            Calories = calories;
            Preparation_time = preparation_time;
        }
    }
}
