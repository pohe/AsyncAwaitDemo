using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{
    public class AsyncBackEnd
    {
        public Task DoTaskA_Async()
        {
            Task t = Task.Run(() => DoTaskA());
            return t;
        }

        public Task DoTaskB_Async()
        {
            Task t = Task.Run(() => DoTaskB());
            return t;
        }


        public Task<int> DoTaskC_Async()
        {
            Task<int> t = Task.Run(() => DoTaskC());
            return t;
        }
        
        public void DoTaskA()
        {
            System.Console.WriteLine("Started in A");
            int milliseconds = 1000;
            Thread.Sleep(milliseconds);
            System.Console.WriteLine("Hi I have finish in A");
        }

        public void DoTaskB()
        {
            System.Console.WriteLine("Started in B");
            int milliseconds = 1000;
            Thread.Sleep(milliseconds);
            System.Console.WriteLine("Hi I have finish in B");
        }

        public int DoTaskC()
        {
            System.Console.WriteLine("Started in C");
            int milliseconds = 100;
            Thread.Sleep(milliseconds);
            Random r = new Random(DateTime.Now.Millisecond);
            int randomTal = r.Next(1, 100);
            System.Console.WriteLine($"Hi I have finish in C returnerer {randomTal}");
            return randomTal;
        }


    }
}
