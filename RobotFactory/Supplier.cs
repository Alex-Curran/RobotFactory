﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotFactory
{
    public abstract class Supplier
    {
        public List<RobotPart> RobotParts { get; set; }
    }
}
