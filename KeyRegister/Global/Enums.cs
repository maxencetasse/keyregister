using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRegister
{
    public static class Enums
    {
        #region ROLES
        public enum Roles
        {
            Etudiant = 1, CM = 2, Admin = 3
        }

        public static string Label(this Roles value)
        {
            switch (value)
            {
                case Roles.Etudiant:    return "Etudiant";
                case Roles.CM:          return "Campus Manager ou assistante manager";
                case Roles.Admin:       return "Administrateur";
                default: return string.Empty;
            }
        }
        #endregion

        #region SESSION
        public enum Session
        {
            Utilisateur = 1
        }

        public static string Label(this Session value)
        {
            switch (value)
            {
                case Session.Utilisateur: return "Utilisateur";
                default: return string.Empty;
            }
        }
        #endregion
    }
}