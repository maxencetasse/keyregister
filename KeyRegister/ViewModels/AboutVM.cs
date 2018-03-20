using KeyRegister.Models;
using KeyRegister.DAL;
using System.Collections.Generic;
using System.Linq;

namespace KeyRegister.ViewModels
{
    public class AboutVM
    {
        private Context _db = new Context();
        
        public List<FAQ> FAQList
        {
            get
            {
                return _db.FAQ.ToList();
            }
        }

        public string FAQComment
        {
            get
            {
                return "Lorem ipsum vaderetro satana...";
            }
        }

        public string Description
        {
            get
            {
                return "La description qui fait plaisir !";
            }
        }
    }
}