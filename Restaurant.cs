using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Консоль_35
{
    internal class Restaurant
    {
        public List<Appetizer> appetizers = new List<Appetizer>();
        public List<MainCourse> maincourses = new List<MainCourse>();
        public List<Desert> deserts = new List<Desert>();
        
        public void AddAppetizer()
        {
            Console.Write("Название блюда: ");
            string name=Console.ReadLine();
            Console.Write("Цена блюда: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Кол-во калорий: ");
            int calories = int.Parse(Console.ReadLine());
            Console.Write("Время приготовления: ");
            int preparation_time = int.Parse(Console.ReadLine());
            Console.Write("Размер порции(гр.): ");
            int serving_size = int.Parse(Console.ReadLine());
            appetizers.Add(new Appetizer(name,price,calories,preparation_time,serving_size));
        }
    }
}
