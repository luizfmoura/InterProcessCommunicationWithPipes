using Dongle.System.Networking.NamedPipes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterProcessCommunication_Pipes
{
    public partial class MainForm : Form
    {
        private bool IsStarted = false;
        private PipeServer PipeServer;

        public MainForm()
        {
            InitializeComponent();
                        
            PipeServer = new PipeServer("pipeserver");
            PipeServer.OnErrorOcurred += exception => MessageBox.Show(exception.ToString());
            PipeServer.OnClientConnected += stream =>
            {
                stream.WriteStringAsync("CONNECTED TO SERVER");
                var input = stream.ReadStringAsync();

                if (input.ToUpper() == "TEST")
                {
                    stream.WriteStringAsync("TESTOK");
                }
                else
                {
                    stream.WriteStringAsync("INVALID COMMAND");
                }
            };
        }

        private void StartServerButton_Click(object sender, EventArgs e)
        {
            try
            {
                PipeServer.Start();
                IsStarted = true;
                StartServerButton.Enabled = false;
                StopServerButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void StopServerButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PipeServer != null && IsStarted)
                {
                    PipeServer.Stop();
                    IsStarted = false;
                    StartServerButton.Enabled = true;
                    StopServerButton.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}