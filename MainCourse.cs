using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Консоль_35
{
    internal class MainCourse : Dish
    {
        int spiciness_level;

        public int Spiciness_level { get => spiciness_level; set => spiciness_level = value; }
        public MainCourse(string name, int price, int calories, int preparation_time, int spiciness_level) : base(name, price, calories, preparation_time)
        {
            Spiciness_level = spiciness_level;
        }
    }
}
