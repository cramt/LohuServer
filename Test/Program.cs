using System;
using System.Threading;
using LohuServer;

namespace Test {
    class Program {
        static void Main(string[] args) {
            LohuEngine engine = new LohuEngine(2313);
            engine.Instances.Add(new LohuInstance(new InstanceImpl(), 1000));
            
            Thread.Sleep(-1);
        }
    }
}
