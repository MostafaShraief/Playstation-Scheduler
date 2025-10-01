using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playstation_Scheduler
{
    public partial class ucStopwatch : UserControl
    {
        public double feePerHour { get; set; }
        private string _stopwatchName;
        public string StopwatchName
        {
            get { return _stopwatchName; }
            set
            {
                _stopwatchName = value;
                if (lblName != null)
                {
                    lblName.Text = value;
                }
            }
        }
        Stopwatch stopwatch;
        CancellationTokenSource cts;
        Task StopwatchTask;

        public ucStopwatch()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
            cts = new CancellationTokenSource();
            lblName.Text = StopwatchName;
        }

        async Task Start()
        {
            cts = new CancellationTokenSource();
            stopwatch.Start();
            try
            {
                while (!cts.IsCancellationRequested && stopwatch.IsRunning)
                {
                    lblTime.Text = stopwatch.Elapsed.ToString(@"hh\:mm\:ss");
                    await Task.Delay(1000, cts.Token);
                }
            }
            catch (OperationCanceledException ex)
            {
                stopwatch.Stop();
                lblTime.Text = stopwatch.Elapsed.ToString(@"hh\:mm\:ss");
                //MessageBox.Show("Paused", "Paused",
                //    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"unexpected error occured: {ex}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Pause()
        {
            cts.Cancel();
        }

        async Task End()
        {
            cts.Cancel();
            await StopwatchTask;
            TimeSpan timeSpan = stopwatch.Elapsed;
            MessageBox.Show($"Total time '{timeSpan.ToString(@"hh\:mm\:ss")}'." +
                $"\nFees = {timeSpan.TotalSeconds * (feePerHour / 3600)} SP", StopwatchName);
            stopwatch.Reset();
            lblTime.Text = stopwatch.Elapsed.ToString(@"hh\:mm\:ss");
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = true;
            if (!stopwatch.IsRunning)
            {
                btnStart.Text = "Pause";
                StopwatchTask = Start();
                await StopwatchTask;
            }
            else
            {
                btnStart.Text = "Start";
                Pause();
            }
        }

        private async void btnEnd_Click(object sender, EventArgs e)
        {
            await End();
            btnStart.Text = "Start";
            btnStop.Enabled = false;
        }
    }
}
