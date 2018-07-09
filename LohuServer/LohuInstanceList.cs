using System;
using System.Collections.Generic;
using System.Text;

namespace LohuServer {
    public class LohuInstanceList : List<LohuInstance> {
        public void Destroy() {
            ForEach(x => x.Dispose());
            Clear();
        }
    }
}
