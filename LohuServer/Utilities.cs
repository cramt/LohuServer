using System;
using System.Collections.Generic;
using System.Text;

namespace LohuServer {
    public static class Utilities {
        public static long UnixTimeStamp {
            //get => (UInt32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalMilliseconds;
            get => DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        }
    }
    static class UtilitiesExtentions {
        
    }
}
