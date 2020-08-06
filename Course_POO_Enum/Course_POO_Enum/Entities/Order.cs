using System;
using System.Collections.Generic;
using System.Text;
using Course_POO_Enum.Entities.Enums;

namespace Course_POO_Enum.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                +", "
                + Status;
        }
    }
}
