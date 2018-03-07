using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KeyRegister.ViewModels
{
    public class ResetVM
    {
        public ResetVM()
        {
            ErrorMessage = string.Empty;
            SuccessMessage = string.Empty;
        }

        [Required(ErrorMessage = "Vous devez saisir votre IdBooster !")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "La taille doit être comprise entre 2 et 30 caractheres")]
        [Display(Name = "IdBooster")]
        public string IdBooster { get; set; }

        public string ErrorMessage { get; set; }
        public string SuccessMessage { get; set; }
    }
}