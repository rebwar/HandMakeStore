using HandMakeStore.Core.Domain.Customers;
using HandMakeStore.FrameWork.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandMakeStore.Core.Domain.Orders.Entity
{
    public class Order:BaseEntity
    {
        public long CustomerId { get; set; }
        public Customer  Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}
