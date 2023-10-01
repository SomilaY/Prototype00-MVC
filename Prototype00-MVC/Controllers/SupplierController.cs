using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prototype00_MVC.Models;

namespace Prototype00_MVC.Controllers
{
    public class SupplierController : Controller
    {
        List<Supplier> suppliersL = new List<Supplier>();

        public SupplierController()
        {
            Populate();
        }
        public void Populate()
        {
            suppliersL.Add(new Supplier("S123", "Fanta", "0145698484"));
            suppliersL.Add(new Supplier("S252", "Coca cola", "0213433432"));
            suppliersL.Add(new Supplier("S546", "pepsi", "0987873789"));
        }
       
        public ActionResult AllSupplier()
        {
            Populate();
            return View(suppliersL);
        }

        public ActionResult sup()
        {
            
            return RedirectToAction("Index","Product");
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]

       public ActionResult VerifyLogin()
        {
        string username = Request.Form["username"].ToString();
        string password = Request.Form["password"].ToString();

            Supplier sp = new Supplier("Somila", "Password1");

            if (username.Equals(sp.Username) && password.Equals(sp.Password))
            {
                return RedirectToAction("AllSupplier");
            }
            else { return View("Login"); }
        }
        // GET: SupplierController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SupplierController1/Create
        public ActionResult Create()
        {
           
            return View();
        }
        [HttpPost]

        public ActionResult CreateNew()
        {
            string supID = Request.Form["txtSuppID"].ToString();
            string supName = Request.Form["txtSupName"].ToString();
            string supPhone = Request.Form["txtPhone"].ToString();
            string supUsername = Request.Form["txtUsername"].ToString();
            string supPassword = Request.Form["txtPassword"].ToString();

            Supplier ss = new Supplier(supID, supName, supPhone);
            ss.Username = supUsername;
            ss.Password = supPassword;
            suppliersL.Add(ss);
            return View("AllSupplier", suppliersL);

        }
        

        // POST: SupplierController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            string supID = collection["txtSuppID"].ToString();
            string supName = collection["txtSupName"].ToString();
            string supPhone = collection["txtPhone"].ToString();
            string supUsername = collection["txtUsername"].ToString();
            string supPassword = collection["txtPassword"].ToString();

            Supplier ss = new Supplier(supID, supName, supPhone);
            ss.Username = supUsername;
            ss.Password = supPassword;
            suppliersL.Add(ss);
            return View("AllSupplier", suppliersL);


        }

        // GET: SupplierController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SupplierController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SupplierController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SupplierController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
