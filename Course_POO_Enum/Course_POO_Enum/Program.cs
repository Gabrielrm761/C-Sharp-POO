using Course_POO_Enum.Entities;
using Course_POO_Enum.Entities.Enums;
using System;

namespace Course_POO_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.pendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.pendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}
