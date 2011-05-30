using System;
using System.Collections;
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
      movies.Add(movie);
      //throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_title_descending
    {
      get { throw new NotImplementedException(); }
    }

    public IEnumerable<Movie> all_movies_published_by_pixar()
    {
      IList<Movie> pixmovies;
     pixmovies = new List<Movie>();

      //this.pixar_movies New movies
     foreach (Movie x in movies)
     {
       if (x.production_studio.Equals(ProductionStudio.Pixar))
       {
         pixmovies.Add(x);
       }
     }
      return pixmovies;
       //throw new NotImplementedException();
      }
 
    public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
    {
      {
        IList<Movie> pixmovies;
        pixmovies = new List<Movie>();

        //this.pixar_movies New movies
        foreach (Movie x in movies)
        {
          if (x.production_studio == ProductionStudio.Pixar | x.production_studio == ProductionStudio.Disney)
          {
            pixmovies.Add(x);
          }
        }
        return pixmovies;
        //throw new NotImplementedException();
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

    public IEnumerable<Movie> all_movies_not_published_by_pixar()
    {
      {
        IList<Movie> pixmovies;
        pixmovies = new List<Movie>();

        //this.pixar_movies New movies
        foreach (Movie x in movies)
        {
          if (x.production_studio != ProductionStudio.Pixar)
          {
            pixmovies.Add(x);
          }
        }
        return pixmovies;
        //throw new NotImplementedException();
      }
    }

    public IEnumerable<Movie> all_movies_published_after(int year)
    {
      {
        {
          IList<Movie> pixmovies;
          pixmovies = new List<Movie>();

          //this.pixar_movies New movies
          foreach (Movie x in movies)
          {
            if (x.date_published.Year > year)
            {
              pixmovies.Add(x);
            }
          }
          return pixmovies;
          //throw new NotImplementedException();
        }
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
            foreach (Movie x in movies)
            {
              if (x.date_published.Year >= startingYear | x.date_published.Year <= endingYear)
              {
                pixmovies.Add(x);
              }
            }
            return pixmovies;
            //throw new NotImplementedException();
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
          foreach (Movie x in movies)
          {
            if (x.genre == Genre.kids )
            {
              pixmovies.Add(x);
            }
          }
          return pixmovies;
          //throw new NotImplementedException();
        }

      }
    }

    public IEnumerable<Movie> all_action_movies()
    {
      {
        {
          IList<Movie> pixmovies;
          pixmovies = new List<Movie>();

          //this.pixar_movies New movies
          foreach (Movie x in movies)
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
  }
}