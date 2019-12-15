using HandMakeStore.Core.Domain.Categories.Entity;
using HandMakeStore.FrameWork.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandMakeStore.Core.Domain.Masters.Entity
{
    public class MasterProduct:BaseEntity
    {
        public Master Master { get; set; }
        public long MasterId { get; set; }
        public Category  Category { get; set; }
        public long CategoryId { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }
        public long Discount { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
    }
}
