using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace LogicalProblems
{
    internal class SimulateStopwatch
    {
        public SimulateStopwatch()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(2);
            }
            stopwatch.Stop();
            Console.WriteLine("End");
            Console.WriteLine("Time elapsed: {0}",stopwatch.Elapsed);
        }
    }
}
