using LocationFinderLibrary.BL.API.Places;
using LocationFinderLibrary.BL.API.Places.Common.DTO;
using LocationFinderLibrary.BL.API.Places.Helpers;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LocationFinderMVC.Controllers
{
    public class HomeController : Controller
    {
        private IPlacesApi _placesApi;

        public HomeController(IPlacesApi placesApi)
        {
            _placesApi = placesApi;
        }

        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> GetNearbyPlacesAsync(PlaceFilterDto placeFilterDto)
        {
            var nearbyPlaces = await _placesApi.GetNearbyPlacesAsync(placeFilterDto);
            return Json(nearbyPlaces, JsonRequestBehavior.AllowGet);
        }

        public async Task<ActionResult> GetCategoriesAsync()
        {
            var categories = await _placesApi.GetCategoriesAsync();
            var result = categories.Select(x => new { Key = x.ID, Value = x.Name }).ToList();
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetRadiuses()
        {
            var result = PlacesApiHelper.GetRadiuses().Select(x => new { Key = x.Meters, Value = $"{ x.Kilometers} km" }).ToList();
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}