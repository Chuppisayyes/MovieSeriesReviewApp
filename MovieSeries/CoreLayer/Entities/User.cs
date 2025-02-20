using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieSeries.CoreLayer.Entities
{
    public class User
    {
        [Key]
        [Column("user_id")]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}
