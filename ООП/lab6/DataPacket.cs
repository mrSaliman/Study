using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace lab6
{
    internal class DataPacket
    {
        public Dictionary<DateTime, double> Http { get; set; }
        public Dictionary<DateTime, double> Ftp { get; set; }
        public Dictionary<DateTime, double> Torrent { get; set; }
        public Dictionary<DateTime, double> Iptv { get; set; }

        public DataPacket()
        {
            this.Http = new();
            this.Ftp = new();
            this.Torrent = new();
            this.Iptv = new();
        }

        public string[] CountAverageTraffic(DateRangeEventArgs e)
        {
            DateTime index = e.Start.Date;
            DateTime end = e.End.Date;
            int days = (end - index).Days + 1;
            double httpSum = 0, ftpSum = 0, torrentSum = 0, iptvSum = 0, maxPacketSum = 0;
            DateTime maxPacketDate = index;
            while (index <= end)
            {
                if (Http.ContainsKey(index))
                {
                    httpSum += Http[index];
                    ftpSum += Ftp[index];
                    torrentSum += Torrent[index];
                    iptvSum += Iptv[index];
                    if (Http[index] + Ftp[index] + Torrent[index] + Iptv[index] > maxPacketSum)
                    {
                        maxPacketSum = Http[index] + Ftp[index] + Torrent[index] + Iptv[index];
                        maxPacketDate = index;
                    }
                }
                index += TimeSpan.FromDays(1);
            }

            return new string[] {
                $"HTTP: {httpSum / days}",
                $"IP-TV: {iptvSum / days}",
                $"torrent: {torrentSum / days}",
                $"FTP: {ftpSum / days}",
                $"Дата с максимальным количеством пакетов: {maxPacketDate:dd.MM.yyyy}"};
        }

        public string[] GetDateStatistics(DateTime dateTime)
        {
            dateTime = dateTime.Date;
            if (Http.ContainsKey(dateTime))
            {
                return new string[4] {
                    $"HTTP: {Http[dateTime]}",
                    $"IP-TV: {Iptv[dateTime]}",
                    $"torrent: {Torrent[dateTime]}",
                    $"FTP: {Ftp[dateTime]}" };
            }
            else
            {
                return new string[4] {
                    $"HTTP: 0",
                    $"IP-TV: 0",
                    $"torrent: 0",
                    $"FTP: 0" };
            }
        }
    }
}
