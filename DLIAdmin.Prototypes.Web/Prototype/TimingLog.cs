using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace DLIAdmin.Prototypes.Web.Prototype
{
    public class TimingLog
    {
        private static object _lock = new object();
        private Stopwatch _stopwatch;
        public TimingLog()
        {
            _stopwatch = Stopwatch.StartNew();
        }

        private readonly List<Tuple<long, int,string>> _logs = new List<Tuple<long,int, string>>();
        public void Stamp(string text)
        {
            lock (_lock)
            {

                _logs.Add(new Tuple<long, int, string>(_stopwatch.ElapsedMilliseconds, Thread.CurrentThread.ManagedThreadId, text));
            }
        }       

        public List<Tuple<long, int, string>> Dump()
        {
            lock (_lock)
            {
                return new List<Tuple<long, int,string>>(_logs);
            }
        }

    }
}