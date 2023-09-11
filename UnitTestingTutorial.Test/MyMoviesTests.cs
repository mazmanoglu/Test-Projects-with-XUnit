using ExampleClass;
using ExampleClass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingTutorial.Test
{
   public class MyMoviesTests
   {
      [Fact]
      public void Should_Return_ThreeMovies()
      {
         MyMovies myMovies = new();
         List<Movie> result = myMovies.GetAll().ToList();
         Assert.Equal(4, result.Count);
      }

      [Fact]
      public void Should_ReturnMovie_When_Found()
      {
         MyMovies myMovies = new();
         Movie result = myMovies.Get(2);
         Assert.NotNull(result);
      }

      #region True But Code Duplicated
      [Fact]
      public void Should_ReturnNull_When_IdIsZero()
      {
         MyMovies myMovies = new();
         Movie result = myMovies.Get(0);
         Assert.Null(result);
      }
      [Fact]
      public void Should_ReturnNull_When_IdIsLessThanZero()
      {
         MyMovies myMovies = new();
         Movie result = myMovies.Get(-3);
         Assert.Null(result);
      }

      [Fact]
      public void Should_ReturnNull_When_MovieIsNotFound()
      {
         MyMovies myMovies = new();
         Movie result = myMovies.Get(99);
         Assert.Null(result);
      }
      #endregion

     

      #region Theory works with a particular set of data
      [Theory]
      [InlineData(0)]
      [InlineData(-473)]
      [InlineData(999)]
      public void Should_ReturnNull_When_IdIsNotvalid(int id)
      {
         MyMovies myMovies = new();

         Movie result = myMovies.Get(id);

         Assert.Null(result);
      }
      #endregion
   }
}
