using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newAirlines.Models
{
    class TypSamolotu
    {
        [Key]
        public int TypId { get; set; }
        public string Nazwa { get; set; }
        public string IloscMiejsc { get; set; }
        public ICollection<Samolot> Samoloty { get; set; }


    }
}
