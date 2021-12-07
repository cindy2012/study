using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPoolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("this is main thread");
            //System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(Dowork), 5);
            //Console.WriteLine("return to main thread 1");
            //System.Threading.Thread.Sleep(10000);
            //Console.WriteLine("return to main thread 2");
            CallContext.LogicalSetData("name", "jeffery");
            ThreadPool.QueueUserWorkItem(state => Console.WriteLine($"Name1={CallContext.LogicalGetData("name")}"));
            Thread.Sleep(2000);
            ExecutionContext.SuppressFlow();
            ThreadPool.QueueUserWorkItem(state => Console.WriteLine($"Name2={CallContext.LogicalGetData("name")}"));
            ExecutionContext.RestoreFlow();
            ThreadPool.QueueUserWorkItem(state => Console.WriteLine($"Name3={CallContext.LogicalGetData("name")}"));

            Console.ReadKey();
        }
        static void Dowork(object second)
        {
            Console.WriteLine("do something in Dowork");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds((int)second));
            Console.WriteLine("something in Dowork has done");
        }
    }
}
