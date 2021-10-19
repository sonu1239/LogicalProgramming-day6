using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    class Stopwatch
    {
		public void stopWatch()
		{
			// Create new stopwatch
			Stopwatch stopwatch = new Stopwatch();

			// Begin timing
			stopwatch.Start();

			// Do something
			for (int i = 0; i < 1000; i++)
			{
				Thread.Sleep(1);
			}

			// Stop timing
			stopwatch.Stop();

			// result
			Console.WriteLine("Time elapsed: {0}",
				stopwatch.Elapsed);
		}

	}
}
