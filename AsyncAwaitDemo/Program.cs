using System;
using System.Threading;

namespace AsyncAwaitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example 1 Executes synchronously
            //Console.WriteLine($"Started main gui");
            ////traditional version - alt udføres sekventielt
            //SyncGUI trad = new SyncGUI();
            //trad.HandleButtonClick();
            //for (int i = 0; i < 100; i++)
            //{
            //    int milliseconds = 10;
            //    Thread.Sleep(milliseconds);
            //    Console.WriteLine($"From main gui {i} - user is working in GUI -  - executes synchronously");
            //}
            #endregion

            #region Example 2 Executes asynchronously with Async/await
            //Async version - udføres asyncront

            //Console.WriteLine($"Started main gui");
            //AsyncGUI asyncGUI = new AsyncGUI();
            //asyncGUI.HandleButtonClickAsync();
            //for (int i = 0; i < 100; i++)
            //{
            //    int milliseconds = 10;
            //    Thread.Sleep(milliseconds);
            //    Console.WriteLine($"From main gui {i} - user is working in GUI - executes asynchronously");
            //}

            #endregion

            Console.ReadLine();
        }
    }
}
