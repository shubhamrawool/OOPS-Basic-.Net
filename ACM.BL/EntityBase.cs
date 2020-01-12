﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public enum EntityStateOptions
    {
        Active,
        Deleted
    }
    public abstract class EntityBase
    {
        public EntityStateOptions EntityState { get; set; }
        public bool HasChanges { get; set; }
        public bool IsNew { get; set; }
        public bool IsValid => Validate();

        public abstract bool Validate();

    }
}
