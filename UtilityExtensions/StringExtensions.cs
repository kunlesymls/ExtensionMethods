using System.Linq;

namespace System
{
    public static class StringExtensions
    {
        /// <summary>
        /// This method converts a string to Upper case and trim all White spaces
        /// </summary>
        /// <param name="stringValue"></param>
        /// <returns></returns>
        public static string ToUpperString(this string stringValue)
        {
            if (!string.IsNullOrEmpty(stringValue))
            {
                stringValue = stringValue.Trim();
                return stringValue.ToUpper();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// This method converts a string to Lower case and trim all White spaces
        /// </summary>
        /// <param name="stringValue"></param>
        /// <returns></returns>
        public static string ToLowerString(this string stringValue)
        {
            if (!string.IsNullOrEmpty(stringValue))
            {
                stringValue = stringValue.Trim();
                return stringValue.ToLower();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// This method converts a string to Sentence case and trim all White spaces
        /// </summary>
        /// <param name="stringValue"></param>
        /// <returns></returns>
        public static string ToSentenseString(this string stringValue)
        {
            if (!string.IsNullOrEmpty(stringValue))
            {
                stringValue = stringValue.Trim();
                return stringValue.First().ToString().ToUpper() + stringValue.Substring(1).ToLower();
            }
            else
            {
                return null;
            }
        }


    }
}
