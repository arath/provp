using System;
using System.Collections.Generic;

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
      return movies;
    }

    public void add(Movie movie)
    {
      bool found = false;

      if (!movies.Contains(movie))
      {
        foreach (Movie x in movies)
        {
          if(x.title == movie.title)
          {
            found = true;
            break;
          }
        }
        if (!found)
        {
          movies.Add(movie);                  
        }

      }
      
      // throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_title_descending
    {
      get { throw new NotImplementedException(); }
    }

    public IEnumerable<Movie> all_movies_published_by_pixar()
    {
      IList<Movie> my_movies;
      my_movies = new List<Movie>();

      foreach (Movie x in movies)
      {
        if (x.production_studio == ProductionStudio.Pixar)
        {
          my_movies.Add(x);
        }
      }
      //throw new NotImplementedException();
      return my_movies;
    }

    public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
    {
      IList<Movie> my_movies;
      my_movies = new List<Movie>();

      foreach (Movie x in movies)
      {
        if (x.production_studio == ProductionStudio.Pixar | x.production_studio == ProductionStudio.Disney)
        {
          my_movies.Add(x);
        }
      }

      //throw new NotImplementedException();
      return my_movies;
    }

    public IEnumerable<Movie> sort_all_movies_by_title_ascending
    {
      get { throw new NotImplementedException(); }
    }

    public IEnumerable<Movie> sort_all_movies_by_movie_studio_and_year_published()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> all_movies_not_published_by_pixar()
    {

      IList<Movie> my_movies;
      my_movies = new List<Movie>();

      foreach (Movie x in movies)
      {
        if (x.production_studio != ProductionStudio.Pixar)
        {
          my_movies.Add(x);
        }
      }

      //throw new NotImplementedException();
      return my_movies;

    }

    public IEnumerable<Movie> all_movies_published_after(int year)
    {
      IList<Movie> my_movies;
      my_movies = new List<Movie>();

      foreach (Movie x in movies)
      {
        if (x.date_published.Year > year)
        {
          my_movies.Add(x);
        }
      }

      //throw new NotImplementedException();
      return my_movies;
    }

    public IEnumerable<Movie> all_movies_published_between_years(int startingYear, int endingYear)
    {
      IList<Movie> my_movies;
      my_movies = new List<Movie>();

      foreach (Movie x in movies)
      {
        if (x.date_published.Year >= startingYear & x.date_published.Year <= endingYear)
        {
          my_movies.Add(x);
        }
      }

      //throw new NotImplementedException();
      return my_movies;      
    }

    public IEnumerable<Movie> all_kid_movies()
    {

      IList<Movie> kid_movies;
      kid_movies = new List<Movie>();

      foreach (Movie x in movies)
      {
        if (x.genre == Genre.kids)
        {
          kid_movies.Add(x);
        }
      }

      //throw new NotImplementedException();
      return kid_movies;
    }

    public IEnumerable<Movie> all_action_movies()
    {
      IList<Movie> action_movies;
      action_movies = new List<Movie>();

      foreach (Movie x in movies)
      {
        if (x.genre ==  Genre.action)
        {
          action_movies.Add(x);
        }
      }

      //throw new NotImplementedException();
      return action_movies;
    }

    public IEnumerable<Movie> sort_all_movies_by_date_published_descending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_date_published_ascending()
    {
      throw new NotImplementedException();
    }
  }
}