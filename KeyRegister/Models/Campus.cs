using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KeyRegister.Models
{
    public class Campus
    {
        public int CampusID { get; set; }
        public string Adresse { get; set; }
        public string CP { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
    }
}