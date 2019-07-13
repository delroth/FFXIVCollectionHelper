using Machina.FFXIV;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFXIVCollectHelper
{
    /// <summary>
    /// Encapsulates a Machina connection monitor to parse relevant FFXIV protocol messages
    /// and provide structured information required for the collection helper app.
    /// </summary>
    class GameMonitor
    {
        private readonly FFXIVNetworkMonitor monitor = new FFXIVNetworkMonitor();

        public void Start()
        {
            monitor.MessageReceived = OnMessageReceived;
            monitor.Start();
        }

        public void Stop()
        {
            monitor.Stop();
        }
        private void OnMessageReceived(string connection, long timestamp, byte[] data)
        {
            Trace.WriteLine("GameMonitor: received packet (ts: " + timestamp + ")");
        }
    }
}
