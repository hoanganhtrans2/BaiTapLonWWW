using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyDoAn.Models;

namespace QuanLyDoAn.Controllers
{
    public class SinhVienController : Controller
    {
        QLDoAnSinhVienEntities db = new QLDoAnSinhVienEntities();
        // GET: SinhVien
        public ActionResult DanhSachDeTai()
        {
            
            var detais = db.DeTais.ToList();
            return View(detais);
        }
        [HttpPost]
        public JsonResult DangKyDeTai(string MaSinhVien, string MaDeTai)
        {
            int count = 0;
            var sv = db.SinhViens.Where(x => x.maSinhVien == MaSinhVien).FirstOrDefault();
            if (sv.maDeTai != null)
                return Json("Bạn đã đăng ký đề tài", JsonRequestBehavior.AllowGet);
            var s = db.DeTais.Where(x => x.maDeTai == MaDeTai).First();
            if (s.soSVDaDangKy < s.soSVThamGia)
            {
                var dtai = db.DeTais.Where(x => x.maDeTai == MaDeTai).FirstOrDefault();
                dtai.soSVDaDangKy += 1;
                count = (int)dtai.soSVDaDangKy;

                sv.maDeTai = MaDeTai;
                //   db.SaveChanges();
            }
            else
            {
                return Json("Đã đủ số lượng", JsonRequestBehavior.AllowGet);
            }

            return Json(count, JsonRequestBehavior.AllowGet);
        }
    }
}