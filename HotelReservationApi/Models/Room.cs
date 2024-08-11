namespace HotelReservationApi.Models
{
    public class Room : BaseModel
    {
        public string name { get; set; }
        public Status Status { get; set; }
        public int RateId { get; set; }
        public double PriceReservation { get; set; }

    }

    public enum Status
    {
        Available,
        pending,
        Reserved
        
    }
}
