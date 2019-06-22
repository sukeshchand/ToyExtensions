using System;

namespace Toy.Extensions.Extensions
{
    public static class StringToTypeExtensions
    {
        public static DateTime? ToDate(this string s) => DateTime.TryParse(s, out DateTime dt) ? (DateTime?)dt : null;

        public static int? ToInt(this string value) => int.TryParse(value, out int intValue) ? (int?)intValue : null;

        public static decimal? ToDecimal(this string value) => decimal.TryParse(value, out decimal intValue) ? (decimal?)intValue : null;

        public static byte? ToByte(this string value) => byte.TryParse(value, out byte byteValue) ? (byte?)byteValue : null;

        public static bool? ToBoolean(this string value) => bool.TryParse(value, out bool boolValue) ? (bool?)boolValue : null;
    }
}

