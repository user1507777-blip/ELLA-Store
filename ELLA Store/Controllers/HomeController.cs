using System.Web.Mvc;

namespace ELLA_Store.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Adidas()
        {
            return View();
        }

        public ActionResult Asics()
        {
            return View();
        }

        public ActionResult Biti()
        {
            return View();
        }

        public ActionResult Nike()
        {
            return View();
        }

        public ActionResult Puma()
        {
            return View();
        }

        public ActionResult ChiTietSanPham(int? id)
        {
            ViewBag.Id = id;
            return View();
        }

        public ActionResult GioHang()
        {
            return View();
        }

        public ActionResult DatHang()
        {
            return View();
        }

        public ActionResult Bill()
        {
            return View();
        }

        public ActionResult DangKy()
        {
            return View();
        }

        public ActionResult DangNhap()
        {
            return View();
        }

        public ActionResult LichSuMuaHang()
        {
            return View();
        }

        public ActionResult ChiTietMuaHang()
        {
            return View();
        }
    }
}