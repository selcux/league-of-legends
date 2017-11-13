using System.Web.Mvc;
using News.Repositories;

namespace News.Controllers {
    public class HomeController : Controller {
        private readonly ICachedNewsRepository _newsRepository;

        public HomeController(ICachedNewsRepository newsRepository) {
            _newsRepository = newsRepository;
        }

        public ActionResult Index() {
            var allNews = _newsRepository.Get();

            return View(allNews);
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}