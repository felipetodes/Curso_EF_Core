﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCare.Domain
{
    public abstract class BaseDomainModel
    {
        public DateTime CreatedDate { get; set; }

    }

}
