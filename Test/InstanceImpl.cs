using LohuServer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Test {
    class InstanceImpl : LohuInstanceRunner {
        int i = 0;
        public override void Update() {
            Console.WriteLine("hello: " + i);
            i++;
        }
    }
}
