using LocationFinderLibrary.BL.API.Places.Common.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LocationFinderLibrary.BL.API.Places
{
    public interface IPlacesApi
    {
        Task<IEnumerable<NearbyPlaceDto>> GetNearbyPlacesAsync(PlaceFilterDto placeFilterDto);
        Task<IEnumerable<CategoryDto>> GetCategoriesAsync();
    }
}
