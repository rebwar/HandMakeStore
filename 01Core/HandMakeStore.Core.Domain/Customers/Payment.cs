using HandMakeStore.FrameWork.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandMakeStore.Core.Domain.Customers
{
    public class Payment:BaseEntity
    {
        public long CustomerId { get; set; }
        public Customer Customer { get; set; }
        public long PaymentValue { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
