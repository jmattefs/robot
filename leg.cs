using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class leg
    {
        int numberOfLegs = 1;
        public bool isTitanium = true;

    public leg()
        {

        }
        public virtual void jump()
        {
            Console.WriteLine("The robot jumped somewhere");
        }
    }
}
