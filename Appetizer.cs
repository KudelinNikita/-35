using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Консоль_35
{
    internal class Appetizer : Dish
    {
        int serving_time;

        public int Serving_time { get => serving_time; set => serving_time = value; }
        public Appetizer(string name, int price, int calories, int preparation_time,int serving_time):base(name, price, calories, preparation_time)
        {
            Serving_time = serving_time;
        }

           
        
    }
}
