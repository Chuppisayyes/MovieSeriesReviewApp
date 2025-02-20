using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MovieSeries.CoreLayer.Entities
{
    [Table("MoviesSeries")]
    public class Movie
    {
        [Key]
        [Column("movie_series_id")] // Chắc chắn SQL Server dùng tên này
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        [Column("release_date")] // Kiểm tra xem SQL Server có tên này không
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }
        public ICollection<MovieSeriesTag> MovieSeriesTags { get; set; }
    }
}
