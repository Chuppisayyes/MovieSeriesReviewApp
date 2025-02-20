using Microsoft.EntityFrameworkCore;
using MovieSeries.CoreLayer.Entities;

namespace MovieSeries.DataAccessLayer
{
    public class MovieRepository : IMovieRepository
    {
        private readonly AppDbContext _context;

        public MovieRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            return await _context.Movies.ToListAsync();
        }

        public async Task AddMovieAsync(Movie movie)
        {
            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();
        }

        public async Task<Movie> PutMovieAsync(int id, Movie newMovie)
        {
            var movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);
            if (movie != null)
            {
                movie.Title = newMovie.Title;
                movie.Genre = newMovie.Genre;
                movie.ReleaseDate = newMovie.ReleaseDate;
                movie.Description = newMovie.Description;
            }
            await _context.SaveChangesAsync();
            return movie;
        }

        public async Task DeleteMovieAsync(int id)
        {
            var movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            return await _context.Movies.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Movie>> GetTopRatedMoviesWithSpAsync(int topCount)
        {
            return await _context.Movies
            .FromSqlRaw("EXEC GetTopRatedMovies @top_count = {0}", topCount)
            .ToListAsync();
        }
    }
}
