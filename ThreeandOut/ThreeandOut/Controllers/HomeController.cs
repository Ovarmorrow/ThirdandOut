using System.Web.Mvc;

namespace ThreeandOut.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "3AO.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Us.";

            return View();
        }
        public ActionResult Schedule()
        {
            ViewBag.Message = "Most Current Schedule.";

            return View();
        }
        public ActionResult Highlights()
        {
            ViewBag.Message = "Highlight videos from the most recent year.";

            return View();
        }
        public ActionResult Roster()
        {
            ViewBag.Message = "A current full team roster.";

            return View();
        }
    }

}