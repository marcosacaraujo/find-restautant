using CoreApp.Interfaces.BL;
using System.Linq;
using System.Web.Mvc;

namespace CoreApp.Web.MVC.Controllers
{
    public class RestaurantController : Controller
    {
        private IRestaurantManager manager;
        public RestaurantController(IRestaurantManager manager)
        {
            this.manager = manager;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            return Json(manager.GetAll().Select(o => new { Id = o.Id, Name = o.Name, Lat = o.Position.Lat, Lon = o.Position.Lon }), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Find(string text)
        {
            return Json(manager.Find(text).Select(o => new { Id = o.Id, Name = o.Name }), JsonRequestBehavior.AllowGet);
        }
    }
}