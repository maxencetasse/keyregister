using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KeyRegister.Models
{
    public class Historique
    {
        public int HistoriqueID { get; set; }
        public int IdBootser { get; set; }
        public int ReservationID { get; set; }
        public int CampusID { get; set; }
        public int EtatID { get; set; }
        public DateTime DateEnregistrement { get; set; }
    }
}