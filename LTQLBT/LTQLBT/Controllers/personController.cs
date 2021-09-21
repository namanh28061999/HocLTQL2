using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using LTQLBT.Models;

namespace LTQLBT.Controllers
{
    public class personController : Controller
    {
        //khai bao dbcontext de lam viec voi database
        private LapTrinhQuanLyDBConText db = new LapTrinhQuanLyDBConText();

        // GET: person
        public ActionResult Index()
        {
            //tra ve view index kem theo list danh sach person trong database
            return View(db.persons.ToList());
        }

        // GET: person/Details/5
        public ActionResult Details(string id)
        {
            //neu id truyen vao = null thi tra trang badrequest
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //tim kiem person theo id duoc gui len
            person person = db.persons.Find(id);
            if (person == null)
            {
                //tra ve trang notfound neu khong tim thay du lieu
                return HttpNotFound();
            }
            //tra ve vie kem theo thong tin cua person tim duoc
            return View(person);
        }

        // GET: person/Create
        public ActionResult Create()
        {
            //tra ve view de cho nguoi dung nhap thong tin
            return View();
        }

        // POST: person/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //quan ly phien lam viec giua client server
        [ValidateAntiForgeryToken]
        //nhan gia tri cac thuoc tinh tu client gui len
        public ActionResult Create( person person)
        {
            //neu thoa man dang buoc ve du lieu
            if (ModelState.IsValid)
            {
                //add vao doi tuong gui len tu phia client vao dbconte
                db.persons.Add(person);
                //luu thay doi vao database
                db.SaveChanges();
                //dieu huong ve action index
                return RedirectToAction("Index");
            }
            //giu nguyen view create kem theo thong bao loi

            return View(person);
        }

        // GET: person/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            person person = db.persons.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // POST: person/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "personID,personName")] person person)
        {
            if (ModelState.IsValid)
            {
                db.Entry(person).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(person);
        }

        // GET: person/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            person person = db.persons.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // POST: person/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            person person = db.persons.Find(id);
            db.persons.Remove(person);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
