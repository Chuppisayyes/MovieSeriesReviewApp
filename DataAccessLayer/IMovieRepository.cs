using MovieSeriesReviewApp.CoreLayer.Entities;

namespace MovieSeriesReviewApp.DataAccessLayer
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetAllMoviesAsync();
        Task AddMovieAsync(Movie movie);
        Task<Movie> GetMovieByIdAsync(int id);
        Task<IEnumerable<Movie>> GetTopRatedMoviesWithSpAsync(int topCount);
    }
}
