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
        public string Nom { get; set; }
    }
}