using Microsoft.AspNetCore.Mvc;
using MovieSeriesReviewApp.CoreLayer.Entities;
using MovieSeriesReviewApp.ServiceLayer.Services;

namespace MovieSeriesReviewApp.Controllers
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

        [HttpPost("")]
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

        [HttpGet("top-rated/{count}")]
        public async Task<IActionResult> GetTopRatedMovies(int count)
        {
            var movies = await _movieService.GetTopRatedMoviesWithSpAsync(count);
            return Ok(movies);
        }

    }
}
