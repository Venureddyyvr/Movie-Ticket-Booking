namespace OnlineMovieTicketBooking.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string SeatNumber { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public int MovieId { get; set; }
    }
}
