﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class springLeg : leg
    {
        public bool isSpring = true;

        public override void jump()
        {
            Console.WriteLine("BOING");
        }

    }
}
