using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newAirlines.Models
{
    class Pasazer
    {
        [Key]
        public string Pesel { get; set; }
        public string Adres { get; set; }
        public string Kraj { get; set; }
        public virtual ICollection<OdprawaPasazer> OdprawaPasazer { get; set; }
    }
}
