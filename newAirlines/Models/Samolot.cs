using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newAirlines.Models
{
    class Samolot
    {

        public int SamolotId { get; set; }

        [Required]
        [Column(TypeName = "nchar")]
        [StringLength(5)]        public string NrSeryjny { get; set; }
        public int? TypId { get; set; }
        public TypSamolotu TypSamolotu { get; set; }

    }
}
