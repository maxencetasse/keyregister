using KeyRegister.DAL;
using KeyRegister.Global;
using KeyRegister.Models;
using KeyRegister.ViewModels;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web.Mvc;

namespace KeyRegister.Controllers
{
    public class UserController : Controller
    {
        private Context _db = new Context();

        // INSCRIPTION
        [HttpGet]
        public ActionResult Subscribe()
        {
            if (UserSession.IfUserExist())
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(new SubscribeVM());
            }
        }

        [HttpPost]
        public ActionResult Subscribe(SubscribeVM model)
        {
            if (ModelState.IsValid)
            {
                int _idBooster;
                bool _idBoosterParsed = Int32.TryParse(model.IdBooster, out _idBooster);

                if (!_idBoosterParsed)
                {
                    model.ErrorMessage = "L'IdBooster doit être un nombre !";
                    return View(model);
                }

                if (false)//model.CampusList == -1)
                {
                    model.ErrorMessage = "Vous devez sélectionner un campus !";
                    return View(model);
                }

                if (_db.Utilisateurs.FirstOrDefault(p => p.IdBooster == _idBooster) != null)
                {
                    model.ErrorMessage = "L'IdBooster est déjà utilisé !";
                    return View(model);
                }

                Utilisateur utilisateur = new Utilisateur()
                {
                    IdBooster = _idBooster,
                    Nom = model.Nom,
                    Prenom = model.Prenom,
                    DateInscription = DateTime.Now,
                    MDP = Method._MD5(model.MDP),
                    Charte = true,
                    //CampusID = model.CampusList,
                    RoleID = (int)Enums.Roles.Etudiant
                };

                _db.Utilisateurs.Add(utilisateur);
                //_db.SaveChanges();

                //TODO : Créer cookie
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }
        
        // CONNEXION
        [HttpGet]
        public ActionResult Login(string SuccessMessage)
        {
            if(UserSession.IfUserExist())
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                LoginVM model = new LoginVM()
                {
                    SuccessMessage = SuccessMessage
                };
                return View(model);
            }
        }

        [HttpPost]
        public ActionResult Login(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                string mdp = string.Empty;
                mdp = Method._MD5(model.MDP);

                Utilisateur utilisateur = _db.Utilisateurs.FirstOrDefault(p => p.IdBooster.ToString() == model.IdBooster && p.MDP == mdp);

                if (utilisateur == null)
                {
                    model.ErrorMessage = "L'identifiant ou le mot de passe est incorrect !";
                    return View(model);
                }
                else
                {
                    UserSession.CreateUser(utilisateur);

                    if (model.Cookies)
                    {
                        //TODO: créer cookie
                    }

                    return RedirectToAction("Index", "Home");
                }
            }
            return View(model);
        }

        // MOT DE PASSE PERDU
        [HttpGet]
        public ActionResult Reset()
        {
            if (UserSession.IfUserExist())
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(new ResetVM());
            }
        }

        [HttpPost]
        public ActionResult Reset(ResetVM model)
        {
            Utilisateur utilisateur = _db.Utilisateurs.FirstOrDefault(p => p.IdBooster.ToString() == model.IdBooster);

            if (utilisateur == null)
            {
                model.ErrorMessage = "L'Idbooster n'est pas enregistré !";
                return View(model);
            }
            else
            {
                //TODO : Faire un envoi de mail (voir la façons a utiliser pour le reset)
                return RedirectToAction("Login", "User", new { SuccessMessage = "Un email vient de vous être envoyés sur votre boîte SUPINFO !" });
            }
        }

        // VOIR SES INFOS
        public ActionResult Details(int id)
        {
            return View();
        }

        // MODIFIER SES INFOS
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection model) //EditVM model)
        {
            return View();
        }

        // DECONNEXION
        public ActionResult Disconnect()
        {
            //TODO: Clear cookie
            GeneralSession.Clear(Enums.Session.Utilisateur.Label());

            return RedirectToAction("Login", "User");
        }
    }
}
