using LocationFinderLibrary.BL.API.Places.Common.DTO;
using LocationFinderLibrary.BL.API.Places.GooglePlaces.DTO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LocationFinderLibrary.BL.API.Places.GooglePlaces
{
    public class GooglePlacesApi : IPlacesApi
    {
        private const string ApiKey = "API_KEY";

        public async Task<IEnumerable<CategoryDto>> GetCategoriesAsync()
        {
            return await Task.Run(() => new List<CategoryDto>()
            {
                new CategoryDto { ID = "0", Name = "All" },
                new CategoryDto { ID = "accounting", Name = "Accounting" },
                new CategoryDto { ID = "airport", Name = "Airport" },
                new CategoryDto { ID = "amusement_park", Name = "Amusement Park" },
                new CategoryDto { ID = "aquarium", Name = "Aquarium" },
                new CategoryDto { ID = "art_gallery", Name = "Art Gallery" },
                new CategoryDto { ID = "atm", Name = "Atm" },
                new CategoryDto { ID = "bakery", Name = "Bakery" },
                new CategoryDto { ID = "bank", Name = "Bank" },
                new CategoryDto { ID = "bar", Name = "Bar" },
                new CategoryDto { ID = "beauty_salon", Name = "Beauty Salon" },
                new CategoryDto { ID = "bicycle_store", Name = "Bicycle Store" },
                new CategoryDto { ID = "book_store", Name = "Book Store" },
                new CategoryDto { ID = "bowling_alley", Name = "Bowling Alley" },
                new CategoryDto { ID = "bus_station", Name = "Bus Station" },
                new CategoryDto { ID = "cafe", Name = "Cafe" },
                new CategoryDto { ID = "campground", Name = "Campground" },
                new CategoryDto { ID = "car_dealer", Name = "Car Dealer" },
                new CategoryDto { ID = "car_rental", Name = "Car Rental" },
                new CategoryDto { ID = "car_repair", Name = "Car Repair" },
                new CategoryDto { ID = "car_wash", Name = "Car Wash" },
                new CategoryDto { ID = "casino", Name = "Casino" },
                new CategoryDto { ID = "cemetery", Name = "Cemetery" },
                new CategoryDto { ID = "church", Name = "Church" },
                new CategoryDto { ID = "city_hall", Name = "City Hall" },
                new CategoryDto { ID = "clothing_store", Name = "Clothing Store" },
                new CategoryDto { ID = "convenience_store", Name = "Convenience Store" },
                new CategoryDto { ID = "courthouse", Name = "Courthouse" },
                new CategoryDto { ID = "dentist", Name = "Dentist" },
                new CategoryDto { ID = "department_store", Name = "Department Store" },
                new CategoryDto { ID = "doctor", Name = "Doctor" },
                new CategoryDto { ID = "drugstore", Name = "Drugstore" },
                new CategoryDto { ID = "electrician", Name = "Electrician" },
                new CategoryDto { ID = "electronics_store", Name = "Electronics Store" },
                new CategoryDto { ID = "embassy", Name = "Embassy" },
                new CategoryDto { ID = "fire_station", Name = "Fire Station" },
                new CategoryDto { ID = "florist", Name = "Florist" },
                new CategoryDto { ID = "funeral_home", Name = "Funeral Home" },
                new CategoryDto { ID = "furniture_store", Name = "Furniture Store" },
                new CategoryDto { ID = "gas_station", Name = "Gas Station" },
                new CategoryDto { ID = "gym", Name = "Gym" },
                new CategoryDto { ID = "hair_care", Name = "Hair Care" },
                new CategoryDto { ID = "hardware_store", Name = "Hardware Store" },
                new CategoryDto { ID = "hindu_temple", Name = "Hindu Temple" },
                new CategoryDto { ID = "home_goods_store", Name = "Home Goods Store" },
                new CategoryDto { ID = "hospital", Name = "Hospital" },
                new CategoryDto { ID = "insurance_agency", Name = "Insurance Agency" },
                new CategoryDto { ID = "jewelry_store", Name = "Jewelry Store" },
                new CategoryDto { ID = "laundry", Name = "Laundry" },
                new CategoryDto { ID = "lawyer", Name = "Lawyer" },
                new CategoryDto { ID = "library", Name = "Library" },
                new CategoryDto { ID = "light_rail_station", Name = "Light Rail Station" },
                new CategoryDto { ID = "liquor_store", Name = "Liquor Store" },
                new CategoryDto { ID = "local_government_office", Name = "Local Government Office" },
                new CategoryDto { ID = "locksmith", Name = "Locksmith" },
                new CategoryDto { ID = "lodging", Name = "Lodging" },
                new CategoryDto { ID = "meal_delivery", Name = "Meal Delivery" },
                new CategoryDto { ID = "meal_takeaway", Name = "Meal Takeaway" },
                new CategoryDto { ID = "mosque", Name = "Mosque" },
                new CategoryDto { ID = "movie_rental", Name = "Movie Rental" },
                new CategoryDto { ID = "movie_theater", Name = "Movie Theater" },
                new CategoryDto { ID = "moving_company", Name = "Moving Company" },
                new CategoryDto { ID = "museum", Name = "Museum" },
                new CategoryDto { ID = "night_club", Name = "Night Club" },
                new CategoryDto { ID = "painter", Name = "Painter" },
                new CategoryDto { ID = "park", Name = "Park" },
                new CategoryDto { ID = "parking", Name = "Parking" },
                new CategoryDto { ID = "pet_store", Name = "Pet Store" },
                new CategoryDto { ID = "pharmacy", Name = "Pharmacy" },
                new CategoryDto { ID = "physiotherapist", Name = "Physiotherapist" },
                new CategoryDto { ID = "plumber", Name = "Plumber" },
                new CategoryDto { ID = "police", Name = "Police" },
                new CategoryDto { ID = "post_office", Name = "Post Office" },
                new CategoryDto { ID = "primary_school", Name = "Primary School" },
                new CategoryDto { ID = "real_estate_agency", Name = "Real Estate Agency" },
                new CategoryDto { ID = "restaurant", Name = "Restaurant" },
                new CategoryDto { ID = "roofing_contractor", Name = "Roofing Contractor" },
                new CategoryDto { ID = "rv_park", Name = "Rv Park" },
                new CategoryDto { ID = "school", Name = "School" },
                new CategoryDto { ID = "secondary_school", Name = "Secondary School" },
                new CategoryDto { ID = "shoe_store", Name = "Shoe Store" },
                new CategoryDto { ID = "shopping_mall", Name = "Shopping Mall" },
                new CategoryDto { ID = "spa", Name = "Spa" },
                new CategoryDto { ID = "stadium", Name = "Stadium" },
                new CategoryDto { ID = "storage", Name = "Storage" },
                new CategoryDto { ID = "store", Name = "Store" },
                new CategoryDto { ID = "subway_station", Name = "Subway Station" },
                new CategoryDto { ID = "supermarket", Name = "Supermarket" },
                new CategoryDto { ID = "synagogue", Name = "Synagogue" },
                new CategoryDto { ID = "taxi_stand", Name = "Taxi Stand" },
                new CategoryDto { ID = "tourist_attraction", Name = "Tourist Attraction" },
                new CategoryDto { ID = "train_station", Name = "Train Station" },
                new CategoryDto { ID = "transit_station", Name = "Transit Station" },
                new CategoryDto { ID = "travel_agency", Name = "Travel Agency" },
                new CategoryDto { ID = "university", Name = "University" },
                new CategoryDto { ID = "veterinary_care", Name = "Veterinary Care" },
                new CategoryDto { ID = "zoo", Name = "Zoo" }
            });
        }

        public async Task<IEnumerable<NearbyPlaceDto>> GetNearbyPlacesAsync(PlaceFilterDto placeFilterDto)
        {
            string categoryFilter = placeFilterDto.CategoryID == "0" ? string.Empty : $"&type={placeFilterDto.CategoryID}";

            string url = $"https://maps.googleapis.com/maps/api/place/nearbysearch/json?location={placeFilterDto.Latitude},{placeFilterDto.Longitude}&radius={placeFilterDto.RadiusInMeters}{categoryFilter}&key={ApiKey}";

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync(url);
                var placesResponse = JsonConvert.DeserializeObject<PlacesResponseDto>(response);

                return placesResponse.Results.Select(x => new NearbyPlaceDto
                {
                    Address = x.Vicinity,
                    Place = x.Name,
                    Category = x.Types.Count == 0 ? string.Empty : x.Types.First()
                });
            }
        }
    }
}
