namespace nothinbutdotnetprep.utility
{
  public delegate PropertyType PropertyAccessor<in ItemToTarget, out PropertyType>(ItemToTarget item);
}