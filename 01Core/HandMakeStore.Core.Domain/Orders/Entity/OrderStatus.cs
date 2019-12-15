using System;
using System.Collections.Generic;
using System.Text;

namespace HandMakeStore.Core.Domain.Orders.Entity
{
    public enum OrderStatus
    {
        New = 1,
        Complete = 2,
        Rejected = 3
    }
}
