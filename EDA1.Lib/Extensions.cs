namespace EDA1.Lib.Extensions
{
    public static class Extensions
    {
        public static bool Contains(this string AString, char AChar)
        {
            return AString.IndexOf(AChar) > -1;
        }
    }
}
