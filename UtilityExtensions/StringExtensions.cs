using System.Linq;

namespace System
{
    public static class StringExtensions
    {
        /// <summary>
        /// By default strings are converted to uppercase unless isUpper argument is set to false.
        /// </summary>
        /// <param name="stringValue"></param>
        /// <param name="isUpper">Optional Parameter</param>
        /// <returns></returns>
        public static string ToMyString(this string stringValue, bool isUpper = true)
        {
            if (!string.IsNullOrEmpty(stringValue))
            {
                stringValue = stringValue.Trim();
                return isUpper ? stringValue.ToUpper() : stringValue.First().ToString().ToUpper() + stringValue.Substring(1).ToLower();
            }
            else
            {
                return null;
            }
        }

    }
}
