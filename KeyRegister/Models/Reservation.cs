using System;

namespace KeyRegister.Models
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public DateTime DateDeb { get; set; }
        public DateTime DateFin { get; set; }
        public int CategorieID { get; set; }
    }
}