using System.Collections;
using System.Collections.Generic;

namespace nothinbutdotnetprep.collections
{
  public class ReadOnlySetOf<T> : IEnumerable<T>
  {
    IList<T> original;

    public ReadOnlySetOf(IList<T> original)
    {
      this.original = original;
    }

    public IEnumerator<T> GetEnumerator()
    {
      return original.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }
  }
}