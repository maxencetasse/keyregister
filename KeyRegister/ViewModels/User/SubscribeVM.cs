using KeyRegister.DAL;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace KeyRegister.ViewModels
{
    public class SubscribeVM : LoginVM
    {
        private Context _db = new Context();
        public SubscribeVM()
        {
            ErrorMessage = "";
            Charte = "Lorem ipsum";
            CharteCheck = false;

            CampusList = new Dictionary<int, string>();
            CampusList.Add(-1, "--- Choisir un campus ---");

            foreach (var campus in _db.Campus.ToList())
            {
                CampusList.Add(campus.CampusID, campus.Ville);
            }
        }
        
        [Required(ErrorMessage = "Vous devez re-saisir votre mot de passe !")]
        [Compare(nameof(MDP), ErrorMessage = "Les mots de passe ne correspondent pas !")]
        [Display(Name = "Mot de passe vérification")]
        public string Verif { get; set; }

        [Required(ErrorMessage = "Vous devez saisir votre nom !")]
        [Display(Name = "Nom")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Vous devez saisir votre prénom !")]
        [Display(Name = "Prénom")]
        public string Prenom { get; set; }
        
        [Display(Name = "Campus")]
        public Dictionary<int, string> CampusList { get; set; }

        [Required(ErrorMessage = "Vous devez accepté la charte d'utilisation !")]
        public bool CharteCheck { get; set; }

        public string Charte { get; set; }
    }
}