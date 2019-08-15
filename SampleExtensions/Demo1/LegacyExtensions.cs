using System;

namespace SampleExtensions.Demo1
{
    public static class LegacyExtensions
    {
        public static string ToLgacyFormat(this DateTime dateTime)
        {
            return dateTime.Year > 1930 ? dateTime.ToString("1yyMMdd") : dateTime.ToString("0yyMMdd");
        }

        public static string ToLgacyName(this string name)
        {
            var parts = name.ToUpper().Trim().Split(' ');
            return $"{parts[1]}, {parts[0]}";
        }
    }
}
