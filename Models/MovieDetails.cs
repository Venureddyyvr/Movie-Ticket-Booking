namespace OnlineMovieTicketBooking.Models
{
    public class MovieDetails
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string MovieDescription { get; set; }
        public DateTime DateAndTime { get; set; }
        public virtual ICollection<BookingTable> Bookings { get; set; }
    }
}
