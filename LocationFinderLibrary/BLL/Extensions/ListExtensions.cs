using LocationFinderLibrary.BLL.API.Places.Common.DTO;
using LocationFinderLibrary.BLL.Predicates;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LocationFinderLibrary.BLL.Extensions
{
    public static class ListExtensions
    {
        public static IEnumerable<T> Flatten<T>(this IEnumerable<T> list, Func<T, IEnumerable<T>> func) => list.SelectMany(x => func(x).Flatten(func)).Concat(list);

        public static IEnumerable<NearbyPlaceDto> SearchAndSortNearbyPlaces(this IEnumerable<NearbyPlaceDto> nearbyPlaces, string term)
        {
            if (string.IsNullOrEmpty(term) || nearbyPlaces.Count() == 0)
            {
                return nearbyPlaces;
            }

            term = term.ToLower();

            var predicate = PredicateBuilder.False<NearbyPlaceDto>()
                .Or(x => x.Address.ToLower().Contains(term))
                .Or(x => x.Place.ToLower().Contains(term))
                .Or(x => x.Category.ToLower().Contains(term));

            return nearbyPlaces.Where(predicate.Compile()).OrderBy(x => x.Place);
        }
    }
}
