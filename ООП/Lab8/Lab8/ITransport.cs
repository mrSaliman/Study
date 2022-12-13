namespace Lab8
{
    interface ITransport
    {
        string StartPoint { get; set; }
        string EndPoint { get; set; }
        string TransportType { get; set; }

        void SetFreePlace(int[] places);

        int GetFreePlace();

        string ShowInfo();

        int this[string placeType]
        {
            get;
            set;
        }
        
    }
}