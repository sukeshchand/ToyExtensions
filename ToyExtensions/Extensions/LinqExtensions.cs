using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Toy.Extensions.Extensions
{
    public static class LinqExtensions
    {
        /// <summary>
        /// Split a list into batches
        /// </summary>
        /// <typeparam name="T">Type of object to split</typeparam>
        /// <param name="source">source object to split</param>
        /// <param name="chunkSize">size of chunk</param>
        /// <returns>Returns another list which contains list of the source list with max count of chunk size</returns>
        public static List<List<T>> ChunkBy<T>(this List<T> source, int chunkSize)
        {
            return source
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / chunkSize)
                .Select(x => x.Select(v => v.Value).ToList())
                .ToList();
        }

    }
}
