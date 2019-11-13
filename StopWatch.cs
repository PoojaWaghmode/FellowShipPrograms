using System;
using System.Threading;

namespace Logical_Programs
{
    class StopWatch
    {
        public void FindElapsedTime()
        {
            Utility u = new Utility();
            DateTime start_time = DateTime.Now;
            int starttime = start_time.Millisecond;
            Console.WriteLine("Start Time:" +start_time);

            Thread.Sleep(10000);

            DateTime stop_time = DateTime.Now;
            int stoptime = stop_time.Millisecond;
            Console.WriteLine("Stop Time:" + stop_time);

            Console.WriteLine("Elapsed Time In MilliSeconds: "+u.CalculateElapsedTime(starttime,stoptime));
                



        }

    }
}
