using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Toy.Extensions.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Truncate string up to a mark
        /// </summary>
        /// <param name="s"></param>
        /// <param name="maxLength"></param>
        /// <returns></returns>
        public static string TruncateString(this string s, int maxLength = 50)
        {
            if (s != null && s.Length > maxLength)
                return s.Substring(0, maxLength);
            return s;
        }
        
        /// <summary>
        /// concatenate list of string with a specified delimiter
        /// </summary>
        /// <param name="s"></param>
        /// <param name="delimiter"></param>
        /// <returns></returns>
        public static string Concat(this List<string> s, string delimiter)
        {
            return s.Aggregate((i, j) => i + delimiter + j);
        }
        
        /// <summary>
        /// replace multiple space with single space in the given string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string RemoveMultipleSpace(this string s) => s == null ? null : Regex.Replace(s, @"\s+", " ");

        /// <summary>
        /// Get string value between [first] a and [last] b.
        /// </summary>
        public static string GetStringBetween(this string value, string a, string b)
        {
            if (string.IsNullOrEmpty(value)) return value;
            var posA = value.IndexOf(a, StringComparison.InvariantCultureIgnoreCase);
            var posB = value.LastIndexOf(b, StringComparison.InvariantCultureIgnoreCase);
            if (posA == -1)
            {
                return "";
            }
            if (posB == -1)
            {
                return "";
            }
            var adjustedPosA = posA + a.Length;
            return adjustedPosA >= posB ? "" : value.Substring(adjustedPosA, posB - adjustedPosA);
        }

        /// <summary>
        /// Get string value before [first] a.
        /// </summary>
        public static string GetStringBefore(this string value, string a)
        {
            if (string.IsNullOrEmpty(value)) return value;
            var posA = value.IndexOf(a, StringComparison.InvariantCultureIgnoreCase);
            if (posA == -1)
            {
                return "";
            }
            return value.Substring(0, posA);
        }

        /// <summary>
        /// Get string value after [last] a.
        /// </summary>
        public static string GetStringAfter(this string value, string a)
        {
            if (string.IsNullOrEmpty(value)) return value;
            var posA = value.LastIndexOf(a, StringComparison.InvariantCultureIgnoreCase);
            if (posA == -1)
            {
                return "";
            }
            var adjustedPosA = posA + a.Length;
            return adjustedPosA >= value.Length ? "" : value.Substring(adjustedPosA);
        }
    }
}

