using System;

namespace LohuServer {
    public class LohuInstance : IDisposable {

        public void Dispose() {

        }

        private readonly LohuInstanceRunner runner;

        public LohuInstance(LohuInstanceRunner runner) {
            this.runner = runner;
        }
    }
}