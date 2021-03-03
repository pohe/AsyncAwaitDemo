using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AsyncAwaitDemo
{
    public class SyncBackend
    {
        
        public void DoTaskA()
        {
            System.Console.WriteLine("Started in A");
            int milliseconds = 100;
            Thread.Sleep(milliseconds);
            System.Console.WriteLine("Hi I have finish in A");
        }

        public void DoTaskB()
        {
            System.Console.WriteLine("Started in B");
            int milliseconds = 100;
            Thread.Sleep(milliseconds);
            System.Console.WriteLine("Hi I have finish in B");
        }

        public int DoTaskC()
        {
            System.Console.WriteLine("Hi I am in C");
            int milliseconds = 100;
            Thread.Sleep(milliseconds);
            Random r = new Random(DateTime.Now.Millisecond);
            int randomTal = r.Next(1, 100);
            System.Console.WriteLine($"Hi I have finish in C returnerer {randomTal}");
            return randomTal;
        }

    }
}
