using System;

namespace KeyRegister.Models
{
    public class Utilisateur
    {
        public int UtilisateurID { get; set; }
        public int IdBooster { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int RoleID { get; set; }
        public int CampusID { get; set; }
        public DateTime DateInscription { get; set; }
        public bool Charte { get; set; }
    }
}