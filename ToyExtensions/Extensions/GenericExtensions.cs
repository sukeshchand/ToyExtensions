using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Toy.Extensions.Extensions
{
    public static class ListExtensions
    {
        public static List<T> ConvertToList<T>(this T obj)
        {
            return new List<T>() { obj };
        }

        public static List<string> ConvertToList(this string value, char separator)
        {
            var returnList = new List<string>();
            if (value == null)
            {
                return returnList;
            }
            returnList = value.Split(separator).ToList();
            return returnList;
        }
        
        public static dynamic GetNearestValue<T>(this List<T> listObj, dynamic nearToValue) where T : IComparable
        {
            return listObj.OrderBy(x => Math.Abs(x - nearToValue)).First();
        }

    }
}
