using System;
using nothinbutdotnetprep.collections;

namespace nothinbutdotnetprep.utility.filtering
{
  public class Where<TItemToMatch>
  {
    public static ComparableCriteriaFactory<TItemToMatch, TPropertyType> has_an<TPropertyType>(
      PropertyAccessor<TItemToMatch, TPropertyType> accessor) where TPropertyType : IComparable<TPropertyType>
    {
      return new ComparableCriteriaFactory<TItemToMatch, TPropertyType>(accessor);
    }

    public static CriteriaFactory<TItemToMatch, TPropertyType> has_a<TPropertyType>(
      PropertyAccessor<TItemToMatch, TPropertyType> accessor)
    {
      return new CriteriaFactory<TItemToMatch, TPropertyType>(accessor);
    }
  }

  public class ComparableCriteriaFactory<TItemToMatch, TPropertyType> where TPropertyType : IComparable<TPropertyType>
  {
    PropertyAccessor<TItemToMatch, TPropertyType> accessor;

    public ComparableCriteriaFactory(PropertyAccessor<TItemToMatch, TPropertyType> accessor)
    {
      this.accessor = accessor;
    }

    public IMatchAn<TItemToMatch> between(TPropertyType start, TPropertyType end)
    {
      return new AnonymousMatch<TItemToMatch>(x => accessor(x).CompareTo(start) >= 0 &&
        accessor(x).CompareTo(end) <= 0);
    }

    public IMatchAn<TItemToMatch> greater_than(TPropertyType value)
    {
      return new AnonymousMatch<TItemToMatch>(x => accessor(x).CompareTo(value) > 0);
      //throw new NotImplementedException();
    }
  }
  }
