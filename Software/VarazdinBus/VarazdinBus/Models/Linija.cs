using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarazdinBus.Models
{
    public class Linija
    {
        public int IdLinije { get; set; }
        public string NazivLinije { get; set; }
        public string PocetnaStanica { get; set; }
        public string ZavrsnaStanica { get; set; }
        public DateTime VrijemePolaska { get; set; }
        public DateTime VrijemeDolaska { get; set; }
        public string vozaci { get; set; }
    }
}