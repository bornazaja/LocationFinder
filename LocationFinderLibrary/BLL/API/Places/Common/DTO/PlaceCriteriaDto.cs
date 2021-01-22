using LocationFinderLibrary.BLL.Pagination;

namespace LocationFinderLibrary.BLL.API.Places.Common.DTO
{
    public class PlaceCriteriaDto
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Term { get; set; }
        public int RadiusInMeters { get; set; }
        public string CategoryID { get; set; }
        public PageCriteriaDto PageCriteriaDto { get; set; }
    }
}
