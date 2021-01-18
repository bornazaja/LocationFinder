namespace LocationFinderLibrary.BL.API.Places.Common.DTO
{
    public class PlaceFilterDto
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int RadiusInMeters { get; set; }
        public string CategoryID { get; set; }
    }
}
