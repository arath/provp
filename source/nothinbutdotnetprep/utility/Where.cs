namespace nothinbutdotnetprep.utility
{
  public class Where<ItemToMatch>
  {
    public static PropertyAccessor<ItemToMatch, PropertyType> has_a<PropertyType>(
      PropertyAccessor<ItemToMatch, PropertyType> accessor)
    {
      return accessor;
    }
  }
}