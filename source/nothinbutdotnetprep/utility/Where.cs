namespace nothinbutdotnetprep.utility
{
  public class Where<TItemToMatch>
  {
    public static CriteriaFactory<TItemToMatch, TPropertyType> has_a<TPropertyType>(
      PropertyAccessor<TItemToMatch, TPropertyType> accessor)
    {
      return new CriteriaFactory<TItemToMatch, TPropertyType>(accessor);
    }
  }
}