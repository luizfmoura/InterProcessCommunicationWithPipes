using Dongle.System.Networking.NamedPipes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SendDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                var text = SendDataTextBox.Text;
                var pipeClient = new PipeClient();
                string result = null;
                var errorOcurred = false;
                pipeClient.OnErrorOcurred += exception =>
                {
                    MessageBox.Show(exception.ToString());
                };
                pipeClient.OnConnected += stream =>
                {
                    stream.ReadStringAsync();
                    stream.WriteStringAsync(text);
                    do
                    {
                        result = stream.ReadStringAsync();
                        ReceivedDataTextBox.AppendText("\n" + result);
                    }
                    while (String.IsNullOrEmpty(result) && !errorOcurred);
                };
                pipeClient.Connect("pipeserver", timeout: 2000);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}