using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingSystem
{
    class Order
    {
        public static List<MenuItem> orderList = new List<MenuItem>();

        public void AddFood(MenuItem menu)
        {
            orderList.Add(menu);
        }     
    }
}
