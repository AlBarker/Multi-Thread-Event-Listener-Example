using System;
using System.Collections.Generic;

namespace multithread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting app...");
            Plugin p = new Plugin();
            p.StartListening();
            
        }
    }
}
