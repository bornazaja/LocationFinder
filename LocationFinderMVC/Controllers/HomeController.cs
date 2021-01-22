using LocationFinderLibrary.BLL.API.Places;
using LocationFinderLibrary.BLL.API.Places.Common.DTO;
using LocationFinderLibrary.BLL.API.Places.Helpers;
using LocationFinderLibrary.BLL.Pagination;
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

        public async Task<ActionResult> GetNearbyPlacesAsync(PlaceCriteriaDto placeCriteriaDto)
        {
            var nearbyPlaces = await _placesApi.GetNearbyPlacesAsync(placeCriteriaDto);
            return Json(nearbyPlaces, JsonRequestBehavior.AllowGet);
        }

        public async Task<ActionResult> GetCategoriesAsync()
        {
            var categories = await _placesApi.GetCategoriesAsync();
            var result = categories.Select(x => new { Key = x.ID, Value = x.Name });
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetRadiuses()
        {
            var result = PlacesApiHelper.GetRadiuses().Select(x => new { Key = x.Meters, Value = $"{ x.Kilometers} km" });
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetItemsPerPageList()
        {
            var result = PaginationHelper.GetItemsPerPageList().Select(x => new { Key = x, Value = x });
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}