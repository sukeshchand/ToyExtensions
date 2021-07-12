using System;

namespace Toy.Extensions.Extensions
{
    public static class StringToTypeExtensions
    {
        /// <summary>
        /// Convert to byte 0 to 255 Unsigned 8-bit integer
        /// </summary>
        /// <param name="value"></param>
        /// <returns>return byte? if valid else return null</returns>
        public static byte? ToByte(this string value) => byte.TryParse(value, out byte byteValue) ? (byte?)byteValue : null;

        /// <summary>
        /// Convert to sbyte -128 to 127 Signed 8-bit integer
        /// </summary>
        /// <param name="value"></param>
        /// <returns>return byte? if valid else return null</returns>
        public static sbyte? ToSByte(this string value) => sbyte.TryParse(value, out sbyte sByteValue) ? (sbyte?)sByteValue : null;

        /// <summary>
        /// Convert to int -2,147,483,648 to 2,147,483,647 Signed 32-bit integer
        /// </summary>
        /// <param name="value"></param>
        /// <returns>return int? value if valid integer else return null </returns>
        public static int? ToInt(this string value) => int.TryParse(value, out int intValue) ? (int?)intValue : null;

        /// <summary>
        /// Convert to uint 0 to 4,294,967,295 Unsigned 32-bit integer
        /// </summary>
        /// <param name="value"></param>
        /// <returns>return uint? value if valid unsigned integer else return null </returns>
        public static uint? ToUInt(this string value) => uint.TryParse(value, out uint uintValue) ? (uint?)uintValue : null;

        /// <summary>
        /// Convert to short -32,768 to 32,767 Signed 16-bit integer
        /// </summary>
        /// <param name="value"></param>
        /// <returns>return short? value if valid short else return null </returns>
        public static short? ToShort(this string value) => short.TryParse(value, out short shortValue) ? (short?)shortValue : null;

        /// <summary>
        /// Convert to ushort 0 to 65,535 Unsigned 16-bit integer
        /// </summary>
        /// <param name="value"></param>
        /// <returns>return ushort? value if valid ushort else return null </returns>
        public static ushort? ToUShort(this string value) => ushort.TryParse(value, out ushort ushortValue) ? (ushort?)ushortValue : null;

        /// <summary>
        /// Convert to long -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 Signed 64-bit integer
        /// </summary>
        /// <param name="value"></param>
        /// <returns>return long? value if valid long else return null </returns>
        public static long? ToLong(this string value) => long.TryParse(value, out long longValue) ? (long?)longValue : null;


        /// <summary>
        /// Convert to ulong 0 to 18,446,744,073,709,551,615 Unsigned 64-bit integer
        /// </summary>
        /// <param name="value"></param>
        /// <returns>return ulong? value if valid ulong else return null </returns>
        public static ulong? ToULong(this string value) => ulong.TryParse(value, out ulong uLongValue) ? (ulong?)uLongValue : null;

        /// <summary>
        /// Convert to decimal
        /// </summary>
        /// <param name="value"></param>
        /// <returns>return decimal if valid else return null</returns>
        public static decimal? ToDecimal(this string value) => decimal.TryParse(value, out decimal decimalValue) ? (decimal?)decimalValue : null;

        public static float? ToFloat(this string value) => float.TryParse(value, out float floatValue) ? (float?)floatValue : null;

        public static double? ToDouble(this string value) => double.TryParse(value, out double doubleValue) ? (double?)doubleValue : null;
        
        public static bool? ToBoolean(this string value) => bool.TryParse(value, out bool boolValue) ? (bool?)boolValue : null;

        public static DateTime? ToDate(this string s) => DateTime.TryParse(s, out DateTime dt) ? (DateTime?)dt : null;

        public static Guid? ToGuid(this string s) => Guid.TryParse(s, out Guid guid) ? (Guid?)guid : null;
    }
}

