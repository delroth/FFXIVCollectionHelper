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

        public delegate void OnPlayerSetupInfoReceived(PlayerSetupInfo info);
        public OnPlayerSetupInfoReceived PlayerSetupInfoReceived;

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
            PlayerSetupInfo info = PlayerSetupInfo.ParseOrNull(data);
            if (info != null)
            {
                Trace.WriteLine(string.Format("GameMonitor: received PlayerSetup packet for player {0}", info.PlayerName));
                Trace.WriteLine(string.Format("Bardings ({0}): {1}", info.AcquiredBardings.Count, string.Join(",", info.AcquiredBardings)));
                Trace.WriteLine(string.Format("Mounts ({0}): {1}", info.AcquiredMounts.Count, string.Join(",", info.AcquiredMounts)));
                Trace.WriteLine(string.Format("Orchestrions ({0}): {1}", info.AcquiredOrchestrions.Count, string.Join(",", info.AcquiredOrchestrions)));

                PlayerSetupInfoReceived?.Invoke(info);
            }
        }
    }
}
