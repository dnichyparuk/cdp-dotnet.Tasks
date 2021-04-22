using System;
using System.Diagnostics;

using System.Threading;

namespace V1.TaskMulth._04
{
    /// <summary>
    /// Write a program which recursively creates 10 threads. Each thread should be with the same body and receive a state with integer number, 
    /// decrement it, print and pass as a state into the newly created thread. Use Thread class for this task and Join for waiting threads.
    /// </summary>
    class Program
    {
        static void Main()
        {
            var threadsCountBeforeCreating = Process.GetCurrentProcess().Threads.Count;

            CreateThread(threadsCountBeforeCreating);
            Console.ReadLine();
        }

        private static void CreateThread(int initThreads, int number = 10)
        {
            throw new NotImplementedException();
        }

    }
}
