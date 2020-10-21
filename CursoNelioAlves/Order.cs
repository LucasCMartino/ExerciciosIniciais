using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves.Enum
{
    enum OrderStatus
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
    class Order
    {
        public int ID { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return ID + ", " + Moment + ", " + Status;
        }
        public static void Executar()
        {
            Order order = new Order
            {
                ID = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);
        }
    }
}

