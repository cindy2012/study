using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ParallelTest
    {
        static readonly object obj = new object();
        public void Run1()
        {
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Method Run1 excute 2s");
        }
        public void Run2()
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Method Run1 excute 3s");
        }

        public void SerialRun()
        {
            System.Diagnostics.Stopwatch t = new System.Diagnostics.Stopwatch();
            t.Start();
            Run1();
            Run2();
            t.Stop();
            Console.WriteLine("串行执行时间："+t.ElapsedMilliseconds);
        }

        public void ParallelRun()
        {
            System.Diagnostics.Stopwatch t = new System.Diagnostics.Stopwatch();
            t.Start();
            System.Threading.Tasks.Parallel.Invoke(Run2, Run1);
            t.Stop();
            Console.WriteLine("并行执行时间：" + t.ElapsedMilliseconds);
        }

        public  void TestParallel()
        {
            SerialRun();
            ParallelRun();
        }

        public void ParallelForTest()
        {
            System.Diagnostics.Stopwatch t = new System.Diagnostics.Stopwatch();
            int sum = 0;
            t.Start();
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 30000; j++)
                {
                    sum++;
                }
            }
            t.Stop();
            Console.WriteLine("正常执行时间："+t.ElapsedMilliseconds+" and sum= "+sum);
            t.Reset();
            t.Start();
            sum = 0;
            System.Threading.Tasks.Parallel.For(0, 10000, (i) =>
            {
                for (int j = 0; j < 30000; j++)
                {
                    lock (obj)
                    {
                        sum++;
                    }
                }
            });
            t.Stop();
            Console.WriteLine("Parallel.For执行时间：" + t.ElapsedMilliseconds + " and sum= " + sum);
        }
        public void ParallelForTest2()
        {
            System.Diagnostics.Stopwatch t = new System.Diagnostics.Stopwatch();
            t.Start();
            for (int i = 0; i < 10000; i++)
            {
                i++;
                for (int j = 0; j < 30000; j++)
                {
                    j++;
                }
            }
            t.Stop();
            Console.WriteLine("正常执行时间：" + t.ElapsedMilliseconds );
            t.Reset();
            t.Start();
            System.Threading.Tasks.Parallel.For(0, 10000, (i) =>
            {
                i++;
                for (int j = 0; j < 30000; j++)
                {
                    j++;
                }
            });
            t.Stop();
            Console.WriteLine("Parallel.For执行时间：" + t.ElapsedMilliseconds );
        }
    }
}
