using System;
using System.Collections.Generic;
using System.Linq;

namespace LocationFinderLibrary.BLL.Extensions
{
    public static class ListExtensions
    {
        public static IEnumerable<T> Flatten<T>(this IEnumerable<T> list, Func<T, IEnumerable<T>> func) => list.SelectMany(x => func(x).Flatten(func)).Concat(list);
    }
}
