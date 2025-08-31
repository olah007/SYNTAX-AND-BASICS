using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Target
{
    public class Publisher
    {
        public delegate void Notify();  // delegate

        public event Notify ProcessCompleted; // event

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            // Some process code here..
            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted()
        {
            // If ProcessCompleted is not null then call delegate
            ProcessCompleted?.Invoke();
        }
    }
}
