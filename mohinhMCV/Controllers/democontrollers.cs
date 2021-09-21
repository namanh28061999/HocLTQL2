using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mohinhMCV.Models;

namespace mohinhMCV.Controllers
{
    public class democontrollers : Controller
    {
        giaiphuongtrinhbac1 gpt = new giaiphuongtrinhbac1();
        // GET:demo
    
    
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult: giai phuong trinh(string soA, string soB)
        {
            int sothunhat = Convert.ToInt32(soA);
            int sothuhai = Convert.ToInt32(soB);
            int giai phuong trinh = gpt.GiaiPhuongTrinhBacNhat(sothunhat, sothuhai);
            ViewBag.Tong = -soB / soA;
            return View();
        }
    }
}
