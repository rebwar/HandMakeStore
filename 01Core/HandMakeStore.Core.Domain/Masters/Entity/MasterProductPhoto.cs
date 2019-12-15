using HandMakeStore.Core.Domain.Photos.Entity;
using HandMakeStore.FrameWork.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandMakeStore.Core.Domain.Masters.Entity
{
   public class MasterProductPhoto:BaseEntity
    {
        public MasterProduct MasterProducts { get; set; }
        public long MasterProductId { get; set; }
        public Photo Photo { get; set; }
        public long PhotoId { get; set; }
    }
}
