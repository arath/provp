using nothinbutdotnetprep.utility;

namespace nothinbutdotnetprep.collections
{
  public class IsInGenre : IMatchAn<Movie>
  {
    Genre genre;

    public IsInGenre(Genre genre)
    {
      this.genre = genre;
    }

    public bool matches(Movie movie)
    {
      return movie.genre == genre;
    }
  }
}