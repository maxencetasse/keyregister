using System;
using System.Collections.Generic;
using KeyRegister.Models;
using System.Data.Entity;
using System.Security.Cryptography;
using System.Text;
using System.Linq;
using KeyRegister.Global;

namespace KeyRegister.DAL
{
    public class Initializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<Context> //CreateDatabaseIfNotExists<Context>
    {
        protected override void Seed(Context context)
        {
            try
            {
                CampusLoader(context);
                CategorieLoader(context);
                EtatLoader(context);
                RoleLoader(context);
                ReservationLoader(context);
                UtilisateurLoader(context);
                HistoriqueLoader(context);
                FAQLoader(context);

                base.Seed(context);
            }

            catch (Exception e)
            {
                var ex = e.Message;
            }
        }

        private void CampusLoader(Context context)
        {
            List<Campus> campus = new List<Campus>()
                {
                    new Campus() { Adresse="10 Rue Alfred Kastler", CP="14000", Ville="Caen", Pays="France", Telephone="+33 1 53 35 97 00", Email="caen@supinfo.com" }
                };

            campus.ForEach(c => context.Campus.Add(c));
            context.SaveChanges();
        }

        private void CategorieLoader(Context context)
        {
            List<Categorie> categorie = new List<Categorie>()
                {
                    new Categorie() { Nom="BDE"},
                    new Categorie() { Nom="Soutien"},
                    new Categorie() { Nom="Laboratoire"}
                };

            categorie.ForEach(c => context.Categories.Add(c));
            context.SaveChanges();
        }

        private void EtatLoader(Context context)
        {
            List<Etat> etat = new List<Etat>()
                {
                    new Etat() { Nom="Demande acceptée"},
                    new Etat() { Nom="Demande en cours"},
                    new Etat() { Nom="Demande annulée"},
                    new Etat() { Nom="Demande refusée"}
                };

            etat.ForEach(e => context.Etats.Add(e));
            context.SaveChanges();
        }

        private void RoleLoader(Context context)
        {
            List<Role> role = new List<Role>()
                {
                    new Role() { Nom="Etudiant"},
                    new Role() { Nom="Campus Manager & assistante manager"},
                    new Role() { Nom="Administrateur"}
                };

            role.ForEach(r => context.Roles.Add(r));
            context.SaveChanges();
        }

        private void ReservationLoader(Context context)
        {
            List<Reservation> reservation = new List<Reservation>()
                {
                    new Reservation() { CategorieID=3, DateDeb=DateTime.Now, DateFin = DateTime.Now.AddDays(1)},
                    new Reservation() { CategorieID=2, DateDeb=DateTime.Now.AddDays(1), DateFin = DateTime.Now.AddDays(2)},
                    new Reservation() { CategorieID=1, DateDeb=DateTime.Now.AddDays(2), DateFin = DateTime.Now.AddDays(3)}
                };

            reservation.ForEach(r => context.Reservations.Add(r));
            context.SaveChanges();
        }

        private void UtilisateurLoader(Context context)
        {
            List<Utilisateur> utilisateur = new List<Utilisateur>()
                {
                    new Utilisateur() {IdBooster = 213559, Nom = "VASSARD", Prenom = "Oweun", RoleID = 3, Charte = false, DateInscription = DateTime.Now, CampusID = 1, MDP = Method._MD5("123")},
                    new Utilisateur() {IdBooster = 285334, Nom = "LOISEL", Prenom = "Virginie", RoleID = 2, Charte = false, DateInscription = DateTime.Now, CampusID = 1, MDP = Method._MD5("123")},
                    new Utilisateur() {IdBooster = 213949, Nom = "TASSE", Prenom = "Maxence", RoleID = 1, Charte = false, DateInscription = DateTime.Now, CampusID = 1, MDP = Method._MD5("123")}
                };

            utilisateur.ForEach(u => context.Utilisateurs.Add(u));
            context.SaveChanges();
        }

        private void HistoriqueLoader(Context context)
        {
            //List<Historique> historique = new List<Historique>()
            //{
            //    new Historique() { idBootser = 213559, dateHistorique = DateTime.Now, idEtat = 1, idCampus = 1 , idReservation = 1}
            //};

            //historique.ForEach(c => context.Historique.Add(c));
            //context.SaveChanges();
        }

        private void FAQLoader(Context context)
        {
            List<FAQ> faq = new List<FAQ>()
            {
                new FAQ() { Question = "Question 1", Reponse = "Réponse 1"},
                new FAQ() { Question = "Question 2", Reponse = "Réponse 2"},
                new FAQ() { Question = "Question 3", Reponse = "Réponse 3"}
            };

            faq.ForEach(c => context.FAQ.Add(c));
            context.SaveChanges();
        }
    }
}