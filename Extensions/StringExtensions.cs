static class StringExtensions
{
  public static string Cut(this string thisObj, int maxLength)
  {
    if (thisObj.Length < maxLength) return thisObj;

    return $"{thisObj.Substring(0, maxLength)}...";
  }
}