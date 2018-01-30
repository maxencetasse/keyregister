using System;

namespace KeyRegister.Models
{
    public class Reservation
    {
        public int idReservation { get; set; }
        public DateTime dateDebReservation { get; set; }
        public DateTime dateFinReservation { get; set; }
        public int idCategorie { get; set; }
    }
}