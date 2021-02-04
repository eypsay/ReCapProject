﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Color:IEntity
    {
        public int ColorId { get; set; }
        public string  Name { get; set; }
        public string Description { get; set; }
    }
}
