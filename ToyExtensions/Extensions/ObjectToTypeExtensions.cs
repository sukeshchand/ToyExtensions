using System;

namespace Toy.Extensions.Extensions
{
    public static class ObjectToTypeExtensions
    {
        public static byte? ToByte(this object value)
        {
            if (value == null) return null;
            var valueString = value.ToString();
            return byte.TryParse(valueString, out var byteValue) ? (byte?)byteValue : null;
        }

        public static sbyte? ToSByte(this object value)
        {
            if (value == null) return null;
            var valueString = value.ToString();
            return sbyte.TryParse(valueString, out var sByteValue) ? (sbyte?)sByteValue : null;
        }

        public static int? ToInt(this object value)
        {
            if (value == null) return null;
            var valueString = value.ToString();
            return int.TryParse(valueString, out var intValue) ? (int?)intValue : null;
        }

        public static uint? ToUInt(this object value)
        {
            if (value == null) return null;
            var valueString = value.ToString();
            return uint.TryParse(valueString, out var uIntValue) ? (uint?)uIntValue : null;
        }

        public static short? ToShort(this object value)
        {
            if (value == null) return null;
            var valueString = value.ToString();
            return short.TryParse(valueString, out var shortValue) ? (short?)shortValue : null;
        }

        public static ushort? ToUShort(this object value)
        {
            if (value == null) return null;
            var valueString = value.ToString();
            return ushort.TryParse(valueString, out var uShortValue) ? (ushort?)uShortValue : null;
        }

        public static long? ToLong(this object value)
        {
            if (value == null) return null;
            var valueString = value.ToString();
            return long.TryParse(valueString, out var longValue) ? (long?)longValue : null;
        }

        public static ulong? ToULong(this object value)
        {
            if (value == null) return null;
            var valueString = value.ToString();
            return ulong.TryParse(valueString, out var uLongValue) ? (ulong?)uLongValue : null;
        }

        public static decimal? ToDecimal(this object value)
        {
            if (value == null) return null;
            var valueString = value.ToString();
            return decimal.TryParse(valueString, out var decimalValue) ? (decimal?)decimalValue : null;
        }

        public static float? ToFloat(this object value)
        {
            if (value == null) return null;
            var valueString = value.ToString();
            return float.TryParse(valueString, out var floatValue) ? (float?)floatValue : null;
        }
        
        public static double? ToDouble(this object value)
        {
            if (value == null) return null;
            var valueString = value.ToString();
            return double.TryParse(valueString, out var doubleValue) ? (double?)doubleValue : null;
        }
        public static bool? ToBoolean(this object value)
        {
            if (value == null) return null;
            var valueString = value.ToString();
            return bool.TryParse(valueString, out var boolValue) ? (bool?)boolValue : null;
        }

        public static DateTime? ToDate(this object value)
        {
            if (value == null) return null;
            var valueString = value.ToString();
            return DateTime.TryParse(valueString, out var dateValue) ? (DateTime?)dateValue.Date : null;
        }

        public static DateTime? ToDateTime(this object value)
        {
            if (value == null) return null;
            var valueString = value.ToString();
            return DateTime.TryParse(valueString, out var dateValue) ? (DateTime?)dateValue : null;
        }
    }
}

