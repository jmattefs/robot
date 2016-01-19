using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            head head = new head();
            arm arm = new arm();
            leg leg = new leg();
            springLeg springLeg = new springLeg();
            gunArm gunArm = new gunArm();
            wreckingballarm wreckingballarm = new wreckingballarm();
            head.look();
            springLeg.jump();
            leg.jump();
            arm.aim();
            gunArm.aim();
            arm.shoot();
            gunArm.shoot();
            arm.swing();
            wreckingballarm.swing();
            springLeg.jump();
            leg.jump();

            
        }
    }
}
