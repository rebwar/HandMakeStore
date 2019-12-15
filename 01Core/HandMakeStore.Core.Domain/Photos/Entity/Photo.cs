using HandMakeStore.FrameWork.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandMakeStore.Core.Domain.Photos.Entity
{
   public class Photo:BaseEntity
    {
        public string Url { get; set; }
        public int Size { get; set; }
    }
}
