using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class gunArm : arm
    {
        public bool hasGun = true;
        int numberOfBullets = 6;

        public override void aim()
        {
            Console.WriteLine("beep Beep BEEP");
        }
        public override void shoot()
        {
            Console.WriteLine("BANG");
        }

    }
}
