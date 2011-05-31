namespace nothinbutdotnetprep.utility
{
  public static class FilteringExtensions
  {
    public static IMatchAn<ItemToMatch> equal_to<ItemToMatch, PropertyType>(
      this PropertyAccessor<ItemToMatch, PropertyType> accessor,
      PropertyType value_to_equal)
    {
      return new AnonymousMatch<ItemToMatch>(x => accessor(x).Equals(value_to_equal));
    }
  }
}