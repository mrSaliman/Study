using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Plain : ITransport
    {
        public int FreePlace;
        public int TripNum;
        public int[] TicketPrice;
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public string TransportType { get; set; }

        public Plain(string transportType, string startPoint, string endPoint, int tripNum, int[] ticketPrice)
        {
            TripNum = tripNum;
            TicketPrice = ticketPrice;
            StartPoint = startPoint;
            EndPoint = endPoint;
            TransportType = transportType;
        }

        public void SetFreePlace(int[] places)
        {
            FreePlace = places[0];
        }

        public int this[string placeType]
        {
            set
            {
                switch (placeType)
                {
                    case "Эконом":
                        TicketPrice[0] = value;
                        break;
                    case "Бизнес":
                        TicketPrice[1] = value;
                        break;
                    case "Первый":
                        TicketPrice[2] = value;
                        break;
                }
            }
            get
            {
                switch (placeType)
                {
                    case "Эконом":
                        return TicketPrice[0];
                    case "Бизнес":
                        return TicketPrice[1];
                    case "Первый":
                        return TicketPrice[2];
                    default:
                        return -1;
                }
            }
        }


        public int GetFreePlace()
        {
            return FreePlace;
        }

        public string ShowInfo()
        {
            return $"{TransportType}; {StartPoint} - {EndPoint}; Номер - {TripNum}; Эконом - {TicketPrice[0]} Бизнес - {TicketPrice[1]} Первый - {TicketPrice[2]}; Свободных мест: {GetFreePlace()}";
        }
    }
}
