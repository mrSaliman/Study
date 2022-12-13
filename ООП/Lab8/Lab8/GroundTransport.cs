using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Lab8
{
    abstract class GroundTransport : ITransport
    {
        public int TripNum;
        public int[] TicketPrice;
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public string TransportType { get; set; }

        public abstract int this[string placeType] { get; set; }

        public GroundTransport(string transportType, string startPoint, string endPoint, int tripNum, int[] ticketPrice)
        {
            TripNum = tripNum;
            TicketPrice = ticketPrice;
            StartPoint = startPoint;
            EndPoint = endPoint;
            TransportType = transportType;
        }


        public abstract int GetFreePlace();

        public abstract void SetFreePlace(int[] places);

        public abstract string ShowInfo();
    }
}
