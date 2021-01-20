using LocationFinderLibrary.BLL.API.Places.Common.DTO;
using System.Collections.Generic;

namespace LocationFinderLibrary.BLL.API.Places.Helpers
{
    public static class PlacesApiHelper
    {
        public static List<RadiusDto> GetRadiuses()
        {
            return new List<RadiusDto>
            {
                new RadiusDto { Meters = 1000, Kilometers = 1 },
                new RadiusDto { Meters = 3000, Kilometers = 3 },
                new RadiusDto { Meters = 5000, Kilometers = 5 }
            };
        }
    }
}
