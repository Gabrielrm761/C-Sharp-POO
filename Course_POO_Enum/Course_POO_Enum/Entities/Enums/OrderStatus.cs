using System;
using System.Collections.Generic;
using System.Text;

namespace Course_POO_Enum.Entities.Enums
{
    enum OrderStatus : int
    {
        pendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
