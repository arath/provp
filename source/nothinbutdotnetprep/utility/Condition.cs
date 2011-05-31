namespace nothinbutdotnetprep.utility
{
  public delegate bool Condition<in ItemToMatch>(ItemToMatch item);
}