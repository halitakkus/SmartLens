﻿using System;
using System.Collections.Generic;
using System.Text;
using SmartLens.Core.Entities;

namespace SmartLens.Entities.Concrate
{
   public class User:IEntity
    {
        public Guid Id { get; set; }
        public string  Name { get; set; }
    }
}
