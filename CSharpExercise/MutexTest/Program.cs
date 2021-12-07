using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MutexTest
{
    class Program
    {
       static bool flag = false;
        static void Main(string[] args)
        {

            using (var s=new SingleGlobalInstance(-1)) //1000ms timeout on global lock
            {
                Start();
                Console.ReadLine();
                flag = false;
            }
            Console.ReadKey();
        }

        static void Start()
        {
            flag = true;
            Task.Run(()=> {
                while (flag)
                {
                    Console.WriteLine("流程正在运行");
                    Thread.Sleep(TimeSpan.FromSeconds(2));
                }
            });
        }
    }
}
