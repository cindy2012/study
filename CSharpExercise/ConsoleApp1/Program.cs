using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static ParallelTest pt = new ParallelTest();
        static void Main(string[] args)
        {
            //TestParallelInvoke();
            //TestParallelFor();
            EnumTest.test();
            Example.TestMain();
            Console.ReadKey();
        }
        
        static void TestParallelInvoke()
        {
            pt.TestParallel();
        }
        static void TestParallelFor()
        {
            pt.ParallelForTest();
            pt.ParallelForTest2();
        }
        static void TestProtect()
        {
            A a = new A();
            B b = new B();
            C c = new C();
            
        }
    }
}
