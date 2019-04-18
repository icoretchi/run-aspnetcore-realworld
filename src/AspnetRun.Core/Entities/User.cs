﻿using AspnetRun.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspnetRun.Core.Entities
{
    public class User : BaseEntity   // Buyer
    {
        public string IdentityGuid { get; set; }
        public AdAccount AdAccount { get; set; }
    }
}