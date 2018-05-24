using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace multithread
{
    class EventListener
    {
        public List<string> Commands { get; set; }

        private int counter;

        public EventListener()
        {
            Commands = new List<string>();
            Thread t = new Thread(ListenForCommands);
            t.Start();
        }

        public void ListenForCommands()
        {
            while (true)
            {
                Commands.Add("Command #" + counter);
                Thread.Sleep(1000);
            }
        }
    }
}
