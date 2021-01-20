using LocationFinderLibrary.BLL.API.Places.Common.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LocationFinderLibrary.BLL.API.Places
{
    public interface IPlacesApi
    {
        Task<IEnumerable<CategoryDto>> GetCategoriesAsync();
        Task<IEnumerable<NearbyPlaceDto>> GetNearbyPlacesAsync(PlaceFilterDto placeFilterDto);
    }
}
