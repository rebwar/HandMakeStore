using HandMakeStore.Core.Domain.Photos.Entity;
using HandMakeStore.FrameWork.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandMakeStore.Core.Domain.Categories.Entity
{
   public class Category:BaseEntity
    {
        public string Name { get; set; }
        public long? ParentId { get; set; }
        public List<Category> Children { get; set; }
        public Photo Photo { get; set; }
        public long PhotoId  { get; set; }

    }
}
