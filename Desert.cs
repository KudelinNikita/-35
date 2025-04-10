using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Консоль_35
{
    internal class Desert : Dish
    {
        bool is_gluten_free;

        public bool Is_gluten_free { get => is_gluten_free; set => is_gluten_free = value; }
        public Desert(string name, int price, int calories, int preparation_time, bool is_gluten_free) : base(name, price, calories, preparation_time)
        {
            Is_gluten_free = is_gluten_free;
        }
    }
}
