﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiChange.Infrastructure
{
    class TraceFilterMatchAll : TraceFilter
    {
        public override bool IsMatch(TypeHandle type, MessageTypes msgTypeFilter, Level level)
        {
            return true;    
        }
    }
}
