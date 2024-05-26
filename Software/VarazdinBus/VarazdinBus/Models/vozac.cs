using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarazdinBus.Models
{
    public class Vozac
    {
        public int vozacId { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string imeVozaca { get; set; }
        public string prezimeVozaca { get; set; }
        public string dozvola { get; set; }
        public DateTime datumRodjenja { get; set; }
        public DateTime datumPocetka { get; set; }
    }
}
