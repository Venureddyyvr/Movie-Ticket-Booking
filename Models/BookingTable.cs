using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMovieTicketBooking.Models
{
    public class BookingTable
    {
        public int Id { get; set; }
        public string SeatNumber { get; set; }
        public int UserId { get; set; }
        public DateTime DateToPresent { get; set; }
        public int MovieDetailsId { get; set; }
        public int Amount { get; set; }
        
        [ForeignKey("MovieDetailsId")]
        public virtual MovieDetails MovieDetails { get; set; }
    }
}
