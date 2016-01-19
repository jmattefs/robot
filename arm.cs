using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class arm
    {
        int numberOfArms = 2;
        public bool isTitanium = true;

     public arm()
        {
            
        }
        public virtual void aim()
        {
            Console.WriteLine("The robot arm gun aimed..");
        }
        public virtual void shoot()
        {
            Console.WriteLine("The robot arm gun shot whatever it decided to aim at");
        }
        public virtual void swing()
        {
            Console.WriteLine("The robot swung it's wrecking ball arm back and...");
        }
    }
}
