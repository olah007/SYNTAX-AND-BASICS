using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Array_Target.Examples;

namespace Array_Target
{
    public class Program
    {
        public static Func<int, int> ExampleDelegate;
        //private static ExampleDelegate exampleDelegate;

        public static int ExampleMethod(int a)
        {
            Console.WriteLine("Example method called with argument: " + a);
            return a*a;
        }

        public static int ExampleMethod2(int a)
        {
            Console.WriteLine("Example method called with argument: " + a);
            return a * a * a;
        }


        //task 1
        static void Main(string[] args)
        {
            int value = 10;
            ExampleDelegate += ExampleMethod;
            //Console.WriteLine("Multiple of Value: " + exampleDelegate?.Invoke(value));
            ExampleDelegate -= ExampleMethod;

            ExampleDelegate += ExampleMethod2;
            Console.WriteLine("Multiple of Value: " + ExampleDelegate?.Invoke(value));
            //exampleDelegate?.Invoke(value);
            //
            //Publisher pub = new Publisher();
            //Subscriber sub = new Subscriber();
            //Examples examples = new Examples();

            ////subscribing to event
            ////pub.ProcessCompleted += sub.FirstProcess;
            ////pub.ProcessCompleted += sub.SecondProcess;
            ////pub.ProcessCompleted += sub.ThirdProcess;

            //pub.StartProcess();

            Console.ReadKey();
            //int[] nums = new int[] { 3, 4, 2, 7 };
            //int target = 9;


            //AddNumber(nums, target);


            //Console.WriteLine("Prime numbers between 1 and 100:");

            //for (int num = 2; num <= 100; num++)
            //{
            //    int count = 0;

            //    for (int i = 1; i <= num; i++)
            //    {
            //        if (num % i == 0)
            //        {
            //            count++;
            //        }
            //    }

            //    if (count == 2)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}
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
