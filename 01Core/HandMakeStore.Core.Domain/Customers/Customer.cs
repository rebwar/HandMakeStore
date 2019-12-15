using HandMakeStore.Core.Domain.Orders.Entity;
using HandMakeStore.FrameWork.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandMakeStore.Core.Domain.Customers
{
    public class Customer:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public List<Order> Orders { get; set; }
        public List<Payment> Payments { get; set; }
        public List<CustomerContact> CustomerContacts { get; set; }
    }
}
