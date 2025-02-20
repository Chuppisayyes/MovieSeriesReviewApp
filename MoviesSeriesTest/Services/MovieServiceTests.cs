using Moq;
using MovieSeries.CoreLayer.Entities;
using MovieSeries.DataAccessLayer;
using MovieSeries.ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesSeriesTest.Services
{
    public class MovieServiceTests
    {
        private readonly Mock<IMovieRepository> _repositoryMock;
        private readonly MovieService _movieService;
        public MovieServiceTests()
        {
            _repositoryMock = new Mock<IMovieRepository>();

            _movieService = new MovieService(_repositoryMock.Object);
        }
        [Fact]
        public async Task AddMovieAsync_ShouldCallRepositoryAddAsync()
        {
            // Arrange
            var movie = new Movie
            {
                Title = "Inception",
                Genre = "Sci-Fi"
            };
            _repositoryMock.Setup(repo =>
            repo.AddMovieAsync(movie)).Returns(Task.CompletedTask);
            // Act
            await _movieService.AddMovieAsync(movie);
            // Assert
            _repositoryMock.Verify(repo => repo.AddMovieAsync(movie),
            Times.Once);
        }
        [Fact]
        public async Task GetAllMoviesAsync_ShouldReturnListOfMovies()
        {
            // Arrange
            var movies = new List<Movie> { new Movie { Title = "Inception" }, new Movie { Title = "The Matrix" } };
            _repositoryMock.Setup(repo => repo.GetAllMoviesAsync()).ReturnsAsync(movies);
            // Act
            var result = await _movieService.GetAllMoviesAsync();
            // Assert
            Assert.Equal(movies, result);
        }
    }


}
