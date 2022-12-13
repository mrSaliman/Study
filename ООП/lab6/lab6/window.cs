using System.Net.Sockets;

namespace lab6
{
    public partial class Window : Form
    {
        private DataPacket packet;

        private void HttpLabel_Enter(object sender, EventArgs e)
        {
            if (sender != null)
            {
                NumericUpDown curLabel = (NumericUpDown)sender;
                //curLabel.Select();
                curLabel.Select(0, curLabel.Text.Length);
            }
        }

        private void averageDatePicker_DateSelected(object sender, DateRangeEventArgs e)
        {
            traficView.Lines = packet.CountAverageTraffic(e);
        }

        private void UpdateWindow(object sender, EventArgs e)
        {
            traficView.Lines = packet.GetDateStatistics(dateTimePicker.Value.Date);
        }

        private void Window_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                packet.Http[dateTimePicker.Value.Date] = (double)httpLabel.Value;
                packet.Ftp[dateTimePicker.Value.Date] = (double)ftpLabel.Value;
                packet.Torrent[dateTimePicker.Value.Date] = (double)torrentLabel.Value;
                packet.Iptv[dateTimePicker.Value.Date] = (double)iptvLabel.Value;
                UpdateWindow(sender, e);
            }
        }

        public Window()
        {
            packet = new();
            InitializeComponent();
        }

        
    }
}