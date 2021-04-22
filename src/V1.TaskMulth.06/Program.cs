using System;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;
using Common;

namespace V1.TaskMulth._06
{
    /// <summary>
    /// Write a program which creates two threads and a shared collection: the first one should add 10 elements into the collection and the second should print all elements in 
    /// the collection after each adding. Use Thread, ThreadPool or Task classes for thread creation and any kind of synchronization 
    /// </summary>
    [SuppressMessage("ReSharper", "InconsistentlySynchronizedField")]
    class Program
    {
        private static ObservableCollection<int> _collection;
        private const int ItemsCount = 10;
        private delegate void Del();
        private static readonly object Locker = new object();

        static void Main()
        {
            throw new NotImplementedException();
        }
    }
}
