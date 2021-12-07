using System;
using System.Linq;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums =  { 2, 7, 11, 15 };
            int target = 26;
            var s = TwoSum(nums, target);
            Console.WriteLine(string.Format("[{0},{1}]",s[0],s[1]));
            Console.ReadKey();
            
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] s = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        s[0] = i;
                        s[1] = j;
                        break;
                    }
                }
            }
            return s;
        }
    }
}
