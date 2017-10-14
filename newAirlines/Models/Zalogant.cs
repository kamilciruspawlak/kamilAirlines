using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newAirlines.Models
{
    class Zalogant
    {
        public int ZalogantId { get; set; }
        public string Pesel { get; set; }
        public int StanowiskoId { get; set; }
        public DateTime DataZatrudnienia { get; set; }
        public string Adres { get; set; }
        public string NrTelefonu { get; set; }
        public int ZalogaId { get; set; }
    }
}
