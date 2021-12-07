using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class PrivateProtectTest : ConsoleApp1.A
    {
        public  void test()
        {
            ConsoleApp1.A a = new ConsoleApp1.A();
            this.x = 1;
            this.z = 2;
            //this.y
        }

    }
}
