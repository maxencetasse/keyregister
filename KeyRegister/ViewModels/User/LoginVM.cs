using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KeyRegister.ViewModels
{
    public class LoginVM : ResetVM
    {
        [Required(ErrorMessage = "Vous devez saisir votre mot de passe !")]
        [Display(Name = "Mot de passe")]
        public string MDP { get; set; }

        [Display(Name = "Retenir")]
        public bool Cookies { get; set; }
    }
}