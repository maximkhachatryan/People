﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.DAL.Entities
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public virtual void Validate() { }
    }
}
