using System.ComponentModel.DataAnnotations.Schema;

namespace MovieSeries.CoreLayer.Entities
{
    public class MovieSeriesTag
    {
        [Column("movie_series_id")]
        public int MovieSeriesId { get; set; }
        [Column("tag_id")]
        public int TagId { get; set; }
        public Movie Movie { get; set; } = null!;
        public Tag Tag { get; set; } = null!;
    }
}
