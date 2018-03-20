using KeyRegister.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KeyRegister.Global
{
    public static class GeneralSession
    {
        /// <summary>
        /// This method test if session variable exist
        /// </summary>
        /// <param name="name">Session name</param>
        /// <returns>True if exist, false if not exist</returns>
        public static bool IfSessionVarExist(string name)
        {
            if (System.Web.HttpContext.Current.Session[name] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Create session variable
        /// </summary>
        /// <typeparam name="T">Type of object</typeparam>
        /// <param name="_object">The object</param>
        /// <param name="_name">Session name</param>
        /// <returns>True if is created whithout problem, False if an error has occured</returns>
        public static bool Create<T>(T _object, string _name)
        {
            try
            {
                System.Web.HttpContext.Current.Session[_name] = _object;
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Get the session variable by session name
        /// </summary>
        /// <param name="name">Session name</param>
        /// <returns>Session variable</returns>
        public static object Get(string name)
        {
            return System.Web.HttpContext.Current.Session[name];
        }

        /// <summary>
        /// Clear session variable
        /// </summary>
        /// <param name="name">Session name</param>
        public static void Clear(string name)
        {
            System.Web.HttpContext.Current.Session[name] = null;
        }
    }

    public static class UserSession
    {
        /// <summary>
        /// Test if user session already exist
        /// </summary>
        /// <returns>True if exist, false if do not exist</returns>
        public static bool IfUserExist()
        {
            return GeneralSession.IfSessionVarExist(Enums.Session.Utilisateur.Label());
        }

        /// <summary>
        /// Create user session
        /// </summary>
        /// <param name="utilisateur">User</param>
        /// <returns>True if is created, false if fail create</returns>
        public static bool CreateUser(Utilisateur utilisateur)
        {
            return GeneralSession.Create<Utilisateur>(utilisateur, Enums.Session.Utilisateur.Label());
        }

        /// <summary>
        /// Get the current user session
        /// </summary>
        /// <returns>Current user</returns>
        public static Utilisateur GetUser()
        {
            return GeneralSession.Get(Enums.Session.Utilisateur.Label()) as Utilisateur;
        }

        /// <summary>
        /// Clean user session
        /// </summary>
        public static void ClearUser()
        {
            GeneralSession.Clear(Enums.Session.Utilisateur.Label());
        }
    }
}
