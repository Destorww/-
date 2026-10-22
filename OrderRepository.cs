using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject23123
{
    public static class OrderRepository
    {
        public static List<Order> Orders { get; } = new List<Order>();

        private static int _nextId = 1;

        public static Order CreateNew()
        {
            return new Order { Id = _nextId++ };
        }

        public static void Add(Order order)
        {
            if (order != null)
                Orders.Add(order);
        }
    }
}