using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieSeries.CoreLayer.Entities
{
    public class Review
    {
        [Key]
        [Column("review_id")]
        public int Id { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("movie_series_id")]
        public int MovieId { get; set; }
        [Column("review_text")]
        public string ReviewText { get; set; }
        [Column("review_date")]
        public DateTime ReviewDate { get; set; }
    }
}
