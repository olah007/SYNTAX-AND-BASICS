using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Target
{
    public class Program
    {
        //task 1
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 4, 2, 7 };
            int target = 9;

            AddNumber(nums, target);
        }

        public static void AddNumber(int[] nums, int target)
        {
            //using loop
            bool resultFound = false;
            for (int i = 0; i < nums.Length; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        resultFound = true;
                        //Console.WriteLine("The indices are: [{0}],[{1}]", i, j);
                        Console.WriteLine($"The indices are: [{i}],[{j}]");
                    }
                } 
            }
            if (resultFound == false)
                Console.WriteLine("Could not find solution!");
        }
    }
}
