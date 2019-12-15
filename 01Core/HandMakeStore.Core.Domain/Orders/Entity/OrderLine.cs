using HandMakeStore.Core.Domain.Masters.Entity;
using HandMakeStore.FrameWork.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandMakeStore.Core.Domain.Orders.Entity
{
    public class OrderLine:BaseEntity
    {
        public Order Order { get; set; }
        public long OrderId { get; set; }
        public long MasterProducstId { get; set; }
        public MasterProduct  MasterProduct { get; set; }
        public int Count { get; set; }
        public long Price { get; set; }
        public long Discount { get; set; }
    }
}
