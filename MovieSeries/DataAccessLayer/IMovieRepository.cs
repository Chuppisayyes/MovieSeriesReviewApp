using MovieSeries.CoreLayer.Entities;

namespace MovieSeries.DataAccessLayer
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetAllMoviesAsync();
        Task AddMovieAsync(Movie movie);
        Task<Movie> PutMovieAsync(int id, Movie newMovie);
        Task DeleteMovieAsync(int id);
        Task<Movie> GetMovieByIdAsync(int id);
        Task<IEnumerable<Movie>> GetTopRatedMoviesWithSpAsync(int topCount);
    }
}
