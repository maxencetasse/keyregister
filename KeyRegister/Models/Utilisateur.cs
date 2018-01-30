using System;

namespace KeyRegister.Models
{
    public class Utilisateur
    {
        public int idBooster { get; set; }
        public string nomUtilisateur { get; set; }
        public string prenomUtilisateur { get; set; }
        public int idRole { get; set; }
        public int idCampus { get; set; }
        public DateTime dateInscriptionUtilisateur { get; set; }
        public bool charteUtilisateur { get; set; }
    }
}