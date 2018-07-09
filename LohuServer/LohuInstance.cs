using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace LohuServer {
    public class LohuInstance : IDisposable {

        public void Dispose() {
            stop = true;
        }

        private readonly LohuInstanceRunner instanceRunner;

        private Task runningThread;

        private bool stop = false;

        public int Tickrate { get; set; }

        public LohuInstance(LohuInstanceRunner runner, int tickrate) {
            Tickrate = tickrate;
            instanceRunner = runner;
            runningThread = Task.Factory.StartNew(() => {
                Stopwatch watch = new Stopwatch();
                while (!stop) {
                    watch.Start();
                    instanceRunner.Update();
                    watch.Stop();
                    watch.Reset();
                    int waitTime = (int)(Tickrate - watch.ElapsedMilliseconds);
                    Console.WriteLine("waitTime: " + waitTime);
                    Thread.Sleep(waitTime < 0 ? 0 : waitTime);
                }
            });
            Console.WriteLine("new thread");
        }
    }
}