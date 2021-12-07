using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EnumTest
    {
        public static void test()
        {
            Console.WriteLine( (int)Seasons.All);
        }
    }
    [Flags]
    public enum Seasons
    {
        None = 0,
        Summer = 1,
        Autumn = 2,
        Winter = 4,
        Spring = 8,
        All = Summer | Autumn | Winter | Spring
    }
}
