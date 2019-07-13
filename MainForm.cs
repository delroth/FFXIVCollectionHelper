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

            monitor.Start();
        }

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            monitor.Stop();
        }
    }
}
