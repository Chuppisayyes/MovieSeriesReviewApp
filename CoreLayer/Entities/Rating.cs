namespace MovieSeriesReviewApp.CoreLayer.Entities
{
    public class Rating
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MovieSeriesId { get; set; }
        public decimal Value { get; set; }
    }
}
