﻿using HandMakeStore.Core.Domain.Photos.Entity;
using HandMakeStore.FrameWork.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandMakeStore.Core.Domain.Masters.Entity
{
    public class Master:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Photo Photo { get; set; }
        public long PhotoId { get; set; }
        public DateTime memberShipDate { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }

    }
}
