using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace multithread
{
    public class Plugin
    {
        
        public void StartListening()
        {
            EventListener listener = new EventListener();

            while (true)
            {
                foreach(var command in listener.Commands)
                {
                    Console.WriteLine("Executing command: " + command);
                }
                listener.Commands.Clear();
                Thread.Sleep(100);
            }
        }
    }
}
