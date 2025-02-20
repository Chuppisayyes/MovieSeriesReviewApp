using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieSeries.CoreLayer.Entities
{
    public class Rating
    {
        [Key]
        [Column("rating_id")]
        public int Id { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("movie_series_id")]
        public int MovieSeriesId { get; set; }
        [Column("rating")]
        public decimal Value { get; set; }
    }
}
