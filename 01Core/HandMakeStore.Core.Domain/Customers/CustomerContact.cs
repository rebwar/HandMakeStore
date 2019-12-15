using HandMakeStore.FrameWork.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandMakeStore.Core.Domain.Customers
{
    public class CustomerContact:BaseEntity
    {
        public long CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
