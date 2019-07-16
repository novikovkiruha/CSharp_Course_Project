using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp_Course_Project
{
    public class Multithreading
    {
        public void Execute()
        {
            //Thread.Sleep(1000);
            //ThreadPriority.
            //ProcessPriorityClass.

            var thread = new Thread(Count);
            Console.WriteLine(Thread.CurrentContext);
            Console.WriteLine(Thread.CurrentThread);
            Console.WriteLine(Thread.CurrentThread.ThreadState);
            Console.WriteLine(Thread.CurrentThread.IsAlive);
            Console.WriteLine(Thread.CurrentThread.IsBackground);
            thread.Start();
            

        }

        public static void Count()
        {
            Thread.Sleep(1000);
        }
    }
}
