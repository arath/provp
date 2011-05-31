namespace nothinbutdotnetprep.utility.filtering
{
  public delegate bool Condition<in ItemToMatch>(ItemToMatch item);
}