using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KeyRegister.Models
{
    public class Historique
    {
        public int idHistorique { get; set; }
        public int idBootser { get; set; }
        public int idReservation { get; set; }
        public int idCampus { get; set; }
        public int idEtat { get; set; }
        public DateTime dateHistorique { get; set; }
    }
}