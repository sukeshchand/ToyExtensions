using System;

namespace Toy.Extensions.Extensions
{
    public static class ObjectToTypeExtensions
    {
        public static int? ToInt(this object value)
        {
            if (value == null) return null;
            var valueString = value.ToString();
            return int.TryParse(valueString, out var intValue) ? (int?)intValue : null;
        }
        public static long? ToLong(this object value)
        {
            if (value == null) return null;
            var valueString = value.ToString();
            return long.TryParse(valueString, out var intValue) ? (long?)intValue : null;
        }
        public static byte? ToByte(this object value)
        {
            if (value == null) return null;
            var valueString = value.ToString();
            return byte.TryParse(valueString, out var intValue) ? (byte?)intValue : null;
        }
        public static decimal? ToDecimal(this object value)
        {
            if (value == null) return null;
            var valueString = value.ToString();
            return decimal.TryParse(valueString, out var intValue) ? (decimal?)intValue : null;
        }
    }
}

