using MovieSeriesReviewApp.CoreLayer.Entities;

namespace MovieSeriesReviewApp.ServiceLayer.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetAllMoviesAsync();
        Task<Movie> GetMovieByIdAsync(int id);
        Task AddMovieAsync(Movie movie);
        Task<IEnumerable<Movie>> GetTopRatedMoviesWithSpAsync(int topCount);
    }
}
