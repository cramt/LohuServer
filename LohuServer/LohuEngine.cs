using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace LohuServer {
    public class LohuEngine {
        private readonly TcpListener tcp;
        public LohuInstanceList Instances { get; } = new LohuInstanceList();
        public LohuEngine(int port) {
            tcp = new TcpListener(new IPEndPoint(IPAddress.Any, port));
        }
    }
}
