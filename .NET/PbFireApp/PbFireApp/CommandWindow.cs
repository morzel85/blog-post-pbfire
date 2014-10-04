using System;
using System.Drawing;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace PbFireApp
{
    public partial class CommandWindow : Form
    {
        private const byte ReadyToFireMessage = 6; // ASCII ACK
        private const byte FireCommand = 70; // ASCII F

        private bool _isReadyToFire;
        private bool IsReadyToFire
        {
            get
            {
                return _isReadyToFire;
            }
            set
            {
                _isReadyToFire = value;
                 SetIsReadyToFireLabel();
            }
        }

        public CommandWindow()
        {
            InitializeComponent();
            
            IsReadyToFire = false;
            spArduino.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            byte data = (byte)spArduino.ReadByte();
            IsReadyToFire = data == ReadyToFireMessage;          
        }

        private void Fire()
        {
            if (!chkSafe.Checked && IsReadyToFire)
            {
                IsReadyToFire = false;
                spArduino.Write(new byte[] { FireCommand }, 0, 1);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (spArduino.IsOpen)
                {
                    spArduino.Close();

                    btnConnect.Text = "Connect";                
                    gbFire.Enabled = false;
                }
                else
                {
                    spArduino.BaudRate = (int)nudBaudRate.Value;
                    spArduino.PortName = txtPortName.Text;

                    spArduino.Open();

                    btnConnect.Text = "Disconnect";            
                    gbFire.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Oh no :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            Fire();
        }

        private void chkSafe_CheckedChanged(object sender, EventArgs e)
        {
            btnFire.Enabled = !chkSafe.Checked;
            chkSafe.ForeColor = chkSafe.Checked ? Color.Green : Color.Red;
        }

        private void CommandWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            spArduino.Close();
        }

        delegate void SetIsReadyToFireLabelCallback();

        private void SetIsReadyToFireLabel()
        {
            if (lblIsReadyToFire.InvokeRequired)
            {
                SetIsReadyToFireLabelCallback d = new SetIsReadyToFireLabelCallback(SetIsReadyToFireLabel);
                Invoke(d, new object[] { });
            }
            else
            {
                lblIsReadyToFire.Text = IsReadyToFire ? "YES" : "NO";
                lblIsReadyToFire.ForeColor = IsReadyToFire ? Color.Orange : Color.Black;
            }
        }
    }
}
