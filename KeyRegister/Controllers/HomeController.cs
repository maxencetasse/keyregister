using KeyRegister.DAL;
using KeyRegister.Global;
using KeyRegister.Models;
using KeyRegister.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace KeyRegister.Controllers
{
    public class HomeController : Controller
    {
        private Context _db = new Context();

        // Accueil
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Reservation()
        {
            ReservationVM booking = new ReservationVM();
            return View(booking);
        }

        [HttpPost]
        public ActionResult Reservation(ReservationVM booking)
        {
            return View(booking);
        }

        // A Propos + Charte
        public ActionResult About()
        {
            return View(new AboutVM());
        }

        // Contact CM
        public ActionResult Contact()
        {
            if (UserSession.IfUserExist() == true)
            {
                int campusId = UserSession.GetUser().CampusID;
                ContactVM model = new ContactVM()
                {
                    Campus = _db.Campus.FirstOrDefault(p => p.CampusID == campusId),
                    Charte = "Lorem ipsum"
                };
                return View(model);
            }
            else
            {
                return RedirectToAction("Login", "User");
            }
        }
    }
}