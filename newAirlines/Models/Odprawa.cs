using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newAirlines.Models
{
    class Odprawa
    {
        public int OdprawaId { get; set; }
        public int LotId { get; set; }
        public int ZalogantId { get; set; }
        public int NrBramki { get; set; }
        public virtual ICollection<OdprawaPasazer> OdprawaPasazer { get; set; }
    }
}
