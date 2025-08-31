using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Target
{
    public class Examples
    {
        public delegate void ExampleDelegate(int a);
        private ExampleDelegate exampleDelegate;

        public static void ExampleMethod(int a)
        {
            Console.WriteLine("Example method called with argument: " + a);
        }

        public void Test()
        {
            int value = 10;
            ExecuteDelegate(value);
        }

        protected void ExecuteDelegate(int value)
        {
            exampleDelegate = ExampleMethod;
            exampleDelegate(value);
        }


    }
}
