using BusinessLayer.Concrete;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Shop.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        ProductRepository productRepository = new ProductRepository();
        public ActionResult Index(int sayfa = 1)
        {
            return View(productRepository.List().ToPagedList(sayfa, 6));
        }
    }
}