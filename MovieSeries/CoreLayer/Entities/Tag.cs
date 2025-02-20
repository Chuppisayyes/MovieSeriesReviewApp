using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieSeries.CoreLayer.Entities
{
    public class Tag
    {
        [Key]
        [Column("tag_id")]
        public int Id {  get; set; }
        [Column("tag_name")]
        public string Name { get; set; }
        public ICollection<MovieSeriesTag> MovieSeriesTags { get; set; }
    }
}
