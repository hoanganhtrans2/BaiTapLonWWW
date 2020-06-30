using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyDoAn.Controllers
{
    public class SinhVienController : Controller
    {
        // GET: SinhVien
        public ActionResult DanhSachDeTai()
        {
            QLDoAnSinhVienEntities db = new QLDoAnSinhVienEntities();
            var detais = db.DeTais.ToList();
            return View(detais);
        }
    }
}