using Machina;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFXIVCollectHelper
{
    public partial class MainForm : Form
    {
        private readonly GameMonitor monitor = new GameMonitor();
        private PlayerSetupInfo info = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            var thisFilename = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            var appName = "FFXIV Collect Helper";
            var fw = new FirewallWrapper();
            if (!fw.IsFirewallDisabled() && !fw.IsFirewallApplicationConfigured(appName))
                fw.AddFirewallApplicationEntry(appName, thisFilename);

            monitor.PlayerSetupInfoReceived = OnPlayerSetupInfoReceived;
            monitor.Start();
        }

        private void OnPlayerSetupInfoReceived(PlayerSetupInfo info)
        {
            monitoringProgressIndicator.Image = Properties.Resources.check;
            monitoringExplanationLabel.Text = $"Found character: {info.PlayerName}. {info.AcquiredMounts.Count} mounts, {info.AcquiredBardings.Count} bardings, {info.AcquiredOrchestrions.Count} orchestrions.";
            importExplanationLabel.Enabled = true;
            copyButton.Enabled = true;

            this.info = info;
        }

        private void OnCopyButtonClicked(object sender, EventArgs e)
        {
            copyButton.Text = "Copied!";
        }

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            monitor.Stop();
        }
    }
}
