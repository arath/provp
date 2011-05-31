using System;
using System.Collections.Generic;
using nothinbutdotnetprep.utility;

namespace nothinbutdotnetprep.collections
{
  public class MovieLibrary
  {
    IList<Movie> movies;

    public MovieLibrary(IList<Movie> list_of_movies)
    {
      this.movies = list_of_movies;
    }

    public IEnumerable<Movie> all_movies()
    {
      return movies.one_at_a_time();
    }

    public void add(Movie movie)
    {
      if (already_contains(movie)) return;

      movies.Add(movie);
    }

    bool already_contains(Movie movie)
    {
      return movies.Contains(movie);
    }

    public bool is_published_by_pixar(Movie movie)
    {
      return movie.production_studio == ProductionStudio.Pixar;
    }

    IEnumerable<Movie> all_matching(MovieCondition condition)
    {
      foreach (var movie in movies)
      {
        if (condition(movie)) yield return movie;
      }
    }

    public IEnumerable<Movie> all_movies_published_by_pixar()
    {
      return all_matching(is_published_by_pixar);
    }

    public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
    {
      return all_matching(movie => movie.production_studio == ProductionStudio.Pixar);
    }

    public IEnumerable<Movie> all_movies_published_after(int year)
    {
      foreach (var movie in movies)
      {
        if (movie.date_published.Year > year)
          yield return movie;
      }
    }

    public IEnumerable<Movie> all_movies_not_published_by_pixar()
    {
      {
        IList<Movie> pixmovies;
        pixmovies = new List<Movie>();

        //this.pixar_movies New movies
        foreach (var x in movies)
        {
          if (x.production_studio != ProductionStudio.Pixar)
          {
            pixmovies.Add(x);
          }
        }
        return pixmovies;
      }
    }

    public IEnumerable<Movie> all_movies_published_between_years(int startingYear, int endingYear)
    {
      {
        {
          {
            IList<Movie> pixmovies;
            pixmovies = new List<Movie>();

            //this.pixar_movies New movies
            foreach (var x in movies)
            {
              if (x.date_published.Year >= startingYear | x.date_published.Year <= endingYear)
              {
                pixmovies.Add(x);
              }
            }
            return pixmovies;
          }
        }
      }
    }

    public IEnumerable<Movie> all_kid_movies()
    {
      {
        {
          IList<Movie> pixmovies;
          pixmovies = new List<Movie>();

          //this.pixar_movies New movies
          foreach (var x in movies)
          {
            if (x.genre == Genre.kids)
            {
              pixmovies.Add(x);
            }
          }
          return pixmovies;
        }
      }
    }

    public IEnumerable<Movie> sort_all_movies_by_title_ascending
    {
      get { throw new NotImplementedException(); }
    }

    public IEnumerable<Movie> sort_all_movies_by_movie_studio_and_year_published()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_title_descending
    {
      get { throw new NotImplementedException(); }
    }

    public IEnumerable<Movie> all_action_movies()
    {
      {
        {
          IList<Movie> pixmovies;
          pixmovies = new List<Movie>();

          //this.pixar_movies New movies
          foreach (var x in movies)
          {
            if (x.genre == Genre.action)
            {
              pixmovies.Add(x);
            }
          }
          return pixmovies;
          //throw new NotImplementedException();
        }
      }
    }

    public IEnumerable<Movie> sort_all_movies_by_date_published_descending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_date_published_ascending()
    {
      throw new NotImplementedException();
    }

    public bool mov { get; set; }
  }
}