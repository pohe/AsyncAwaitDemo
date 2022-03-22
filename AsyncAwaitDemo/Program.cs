using System;
using System.Threading;

namespace AsyncAwaitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Started main gui");
            //traditional version - alt udføres sekventielt
            //SyncGUI trad = new SyncGUI();
            //trad.HandleButtonClick();


            //Async version - udføres asyncront
            AsyncGUI asyncGUI = new AsyncGUI();
            asyncGUI.HandleButtonClickAsync();
            for (int i = 0; i < 100; i++)
            {
                int milliseconds = 10;
                Thread.Sleep(milliseconds);
                Console.WriteLine($"From main gui {i}");
            }

            int sleep = 1000;
            Thread.Sleep(sleep);
            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
