using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarazdinBus.Models
{
    public class Djelatnik
    {
        public int djelatnikId { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string imeDjelatnika { get; set; }
        public string prezimeDjelatnika { get; set; }
        public string radniStaz { get; set; }
        public string datumRodjenja { get; set; }
        public string datumPocetka { get; set; }
    }
}
