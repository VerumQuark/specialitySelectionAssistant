using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace specialitySelectionAssistant.Utility
{
    static class TestTimer
    {
        static private CancellationTokenSource cts;
        static private CancellationToken token;

        static private bool isTimerRun;

        static public DateTime time;

        static TestTimer()
        {
            cts = new CancellationTokenSource();
            token = cts.Token;

            time = new DateTime();

            isTimerRun = false;
        }

        static async public void StartTimer()
        {
            if (isTimerRun) return;
            isTimerRun = true;

            cts = new CancellationTokenSource();
            token = cts.Token;

            await foreach (DateTime newTime in TimerRunAsync())
            {
                time = newTime;
            }
        }

        static public void StopTimer()
        {
            cts.Cancel();

            isTimerRun = false;
        }

        private static async IAsyncEnumerable<DateTime> TimerRunAsync()
        {
            while (token.IsCancellationRequested == false)
            {
                await Task.Delay(1000);
                yield return time.AddSeconds(1);
            }
        }
    }
}
