using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mohinhMCV.Controllers
{
    public class studentcontroller : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return view();
        }

        public ActionResult GetInfo()
        {
            return view();

        }
        [HttpPost]
        public ActionResult GetInfo(string ten,string tuoi,string lop)
        {
            viewBang.ten = ten;
            viewbang.tuoi = tuoi;
            viewbang.lop = lop;
            return view();

        }
    }
}

 