using LocationFinderLibrary.BLL.API.Places.Common.DTO;
using LocationFinderLibrary.BLL.API.Places.Foursquare.DTO.Categories;
using LocationFinderLibrary.BLL.API.Places.Foursquare.DTO.Venues;
using LocationFinderLibrary.BLL.Extensions;
using LocationFinderLibrary.BLL.Pagination;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LocationFinderLibrary.BLL.API.Places.Foursquare
{
    public class FoursquarePlacesApi : IPlacesApi
    {
        private const string ClientId = "CLIENT_ID";
        private const string ClientSecret = "CLIENT_SECRET";
        private const string DateFormat = "yyyyMMdd";

        public async Task<IEnumerable<CategoryDto>> GetCategoriesAsync()
        {
            string url = $"https://api.foursquare.com/v2/venues/categories?client_id={ClientId}&client_secret={ClientSecret}&v={DateTime.Now.ToString(DateFormat)}";

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync(url);
                var categoriesResponse = JsonConvert.DeserializeObject<CategoriesResponseDto>(response);

                List<CategoryDto> categoriesToAppend = categoriesResponse.Response.Categories
                    .Flatten(x => x.Categories)
                    .OrderBy(x => x.Name)
                    .Select(x => new CategoryDto { ID = x.ID, Name = x.Name })
                    .ToList();

                List<CategoryDto> categoriesList = new List<CategoryDto> { new CategoryDto { ID = "0", Name = "All" } };
                categoriesList.AddRange(categoriesToAppend);

                return categoriesList;
            }
        }

        public async Task<PagedList<NearbyPlaceDto>> GetNearbyPlacesAsync(PlaceCriteriaDto placeCriteriaDto)
        {
            string categoryFilter = placeCriteriaDto.CategoryID == "0" ? string.Empty : $"&categoryId={placeCriteriaDto.CategoryID}";

            string url = $"https://api.foursquare.com/v2/venues/search?client_id={ClientId}&client_secret={ClientSecret}&ll={placeCriteriaDto.Latitude},{placeCriteriaDto.Longitude}&radius={placeCriteriaDto.RadiusInMeters}{categoryFilter}&v={DateTime.Now.ToString(DateFormat)}";

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync(url);
                var venuesResponse = JsonConvert.DeserializeObject<VenuesResponseDto>(response);

                IEnumerable<NearbyPlaceDto> nearbyPlaces = venuesResponse.Response.Venues.Select(x => new NearbyPlaceDto
                {
                    Address = x.Location.FormattedAddress.Count == 0 ? string.Empty : string.Join(", ", x.Location.FormattedAddress),
                    Place = x.Name,
                    Category = x.Categories.Count == 0 ? string.Empty : x.Categories.Where(c => c.Primary).FirstOrDefault().Name
                }).SearchAndSortNearbyPlaces(placeCriteriaDto.Term);

                return new PagedList<NearbyPlaceDto>(nearbyPlaces, placeCriteriaDto.PageCriteriaDto.PageIndex, placeCriteriaDto.PageCriteriaDto.PageSize);
            }
        }
    }
}
