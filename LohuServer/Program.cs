using LohuServer;
using System;
using System.Net.Sockets;
using System.Threading;

namespace Testing {
    class Program {
        static void Main(string[] args) {
            LohuEngine engine = new LohuEngine(2312);
            Thread.Sleep(-1);
        }
    }
}
