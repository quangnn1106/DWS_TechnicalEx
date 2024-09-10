﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedDomain.Entities.Base
{
    public interface ITraceableItem : ISoftDeletable
    {
        public DateTime CreatedDate { get; set; }
        public DateTime LastModify { get; set; }
    }
}
