using MovieSeries.CoreLayer.Entities;

namespace MovieSeries.ServiceLayer.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetAllMoviesAsync();
        Task<Movie> GetMovieByIdAsync(int id);
        Task AddMovieAsync(Movie movie);
        Task<Movie> PutMovieAsync(int id, Movie newMovie);
        Task DeleteMovieAsync(int id);
        Task<IEnumerable<Movie>> GetTopRatedMoviesWithSpAsync(int topCount);
    }
}
