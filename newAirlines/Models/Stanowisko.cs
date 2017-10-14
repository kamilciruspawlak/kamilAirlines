using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newAirlines.Models
{
    class Stanowisko
    {
        public int StanowiskoId { get; set; }
        public string Nazwa { get; set; }
        public virtual ICollection<Zalogant> Zalogant { get; set; }
    }
}
