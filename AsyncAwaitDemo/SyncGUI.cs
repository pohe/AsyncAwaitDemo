using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{
    public class SyncGUI
    {
        public SyncBackend SyncBackend { get; set; }
        public SyncGUI()
        {
            SyncBackend = new SyncBackend();
        }
        public void HandleButtonClick()
        {
            SyncBackend.DoTaskA();
            SyncBackend.DoTaskB();
            int result = SyncBackend.DoTaskC();
            Console.WriteLine($"I got {result} from DoTaskC()");
            Console.WriteLine("All done HandleButtonClick");
        }


    }
}
