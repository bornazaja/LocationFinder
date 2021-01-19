using LocationFinderLibrary.BL.API.Places.Common.DTO;
using System.Collections.Generic;

namespace LocationFinderLibrary.BL.API.Places.Helpers
{
    public static class PlacesApiHelper
    {
        public static List<RadiusDTO> GetRadiuses()
        {
            return new List<RadiusDTO>()
            {
                new RadiusDTO { Meters = 1000, Kilometers = 1 },
                new RadiusDTO { Meters = 3000, Kilometers = 3 },
                new RadiusDTO { Meters = 5000, Kilometers = 5 }
            };
        }
    }
}
