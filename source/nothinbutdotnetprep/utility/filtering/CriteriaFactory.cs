using System.Collections.Generic;

namespace nothinbutdotnetprep.utility.filtering
{
  public class CriteriaFactory<TItemToMatch, TPropertyType>
  {
    PropertyAccessor<TItemToMatch, TPropertyType> accessor;

    public CriteriaFactory(PropertyAccessor<TItemToMatch, TPropertyType> accessor)
    {
      this.accessor = accessor;
    }

    public IMatchAn<TItemToMatch> equal_to(TPropertyType value)
    {
      return new AnonymousMatch<TItemToMatch>(x => accessor(x).Equals(value));
    }

    public IMatchAn<TItemToMatch> equal_to_any(params TPropertyType[] potential_values)
    {
      return new AnonymousMatch<TItemToMatch>(item_to_match => new List<TPropertyType>(potential_values)
                                                .Contains(accessor(item_to_match)));
    }

    public IMatchAn<TItemToMatch> not_equal_to(TPropertyType value)
    {
      return equal_to(value).not();
    }
  }
}