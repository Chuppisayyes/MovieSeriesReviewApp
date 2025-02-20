using Microsoft.AspNetCore.Mvc;
using MovieSeries.CoreLayer.Entities;
using MovieSeries.ServiceLayer.Services;

namespace MovieSeries.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpPost]
        public async Task<IActionResult> AddMovie(Movie movie)
        {
            await _movieService.AddMovieAsync(movie);
            return Created();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovie(int id)
        {
            var movie = await _movieService.GetMovieByIdAsync(id);
            if (movie == null) return NotFound();
            return Ok(movie);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovie(int id, Movie movie)
        {
            var result = await _movieService.PutMovieAsync(id, movie);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            await _movieService.DeleteMovieAsync(id);
            return NoContent();
        }

        [HttpGet("top-rated/{count}")]
        public async Task<IActionResult> GetTopRatedMovies(int count)
        {
            var movies = await _movieService.GetTopRatedMoviesWithSpAsync(count);
            return Ok(movies);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMovies()
        {
            var movies = await _movieService.GetAllMoviesAsync();
            return Ok(movies);
        }
    }
}
