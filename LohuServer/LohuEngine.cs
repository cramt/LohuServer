using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace LohuServer {
    class LohuEngine: List<LohuInstance> {
        private TcpListener tcp;
        public LohuEngine(int port) {
            tcp = new TcpListener(new IPEndPoint(IPAddress.Any, port));
        }
    }
}
