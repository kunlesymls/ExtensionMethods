namespace System
{
    public static class DateExtensions
    {
        public static string ToLocalFormat(this DateTime dateTime)
        {
            return dateTime.ToString("dd MMM yyyy");
        }

    }
}
