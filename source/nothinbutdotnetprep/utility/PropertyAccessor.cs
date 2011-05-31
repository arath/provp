namespace nothinbutdotnetprep.utility
{
  public delegate TPropertyType PropertyAccessor<in TItemToTarget, out TPropertyType>(TItemToTarget item);
}