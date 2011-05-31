namespace nothinbutdotnetprep.utility
{
  public class NeverMatchesAn<TItemToMatch> : IMatchAn<TItemToMatch>
  {
    public bool matches(TItemToMatch item)
    {
      return false;
    }
  }
}