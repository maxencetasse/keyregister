using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KeyRegister.Models;

namespace KeyRegister.ViewModels
{
    public class ReservationVM
    {
        [HiddenInput(DisplayValue=false)]
        public int ReservationID { get; set; }

        [Required(ErrorMessage = "Vous devez saisir votre Nom !")]
        [StringLength(30,MinimumLength =2)]
        [Display (Name = "Votre Nom")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Vous devez saisir votre Prénom !")]
        [StringLength(30, MinimumLength = 2)]
        [Display(Name = "Votre Prénom")]
        public string Prenom { get; set; }

        [Required(ErrorMessage = "Vous devez saisir votre IdBooster !")]
        public int IdBooster { get; set; }

        [Required(ErrorMessage = "Vous devez saisir une date valide de début de réservation !")]
        [DataType(DataType.Date)]
        public DateTime DateDeb { get; set; }

        [Required(ErrorMessage = "Vous devez saisir une date valide de fin de réservation !")]
        [DataType(DataType.Date)]
        public DateTime DateFin { get; set; }

        [Display(Name = "Catégorie de Réservation")]
        public int CategorieID { get; set; }
    }
}