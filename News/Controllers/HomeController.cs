using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using News.Models;
using News.Repositories;

namespace News.Controllers {
    public class HomeController : Controller {
        private readonly ICachedNewsRepository _newsRepository;

        private int PageCount(IEnumerable<NewsModel> allNews) =>
            (int) Math.Ceiling((double) allNews.Count() / StaticValues.Page.PageSize);

        private int CurrentPage {
            get {
                var currentPageStr = Request.QueryString["page"];
                if (!int.TryParse(currentPageStr, out var currentPage)) {
                    currentPage = 1;
                }

                return currentPage;
            }
        }

        public HomeController(ICachedNewsRepository newsRepository) {
            _newsRepository = newsRepository;
        }

        public ActionResult Index() {
            var currentPage = CurrentPage;
            var pageOffset = (currentPage - 1) * StaticValues.Page.PageSize;
            var allNews = _newsRepository.Get().ToArray();

            var news = allNews.Skip(pageOffset)
                .Take(StaticValues.Page.PageSize);

            ViewBag.Page = currentPage;
            ViewBag.PageCount = PageCount(allNews);

            return View(news);
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