using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newAirlines.Models
{
    class Lot
    {

        public int LotId { get;  set;}
        public string NumerLotu { get; set; }
        public int KierunekId { get;  set;}
        public int SamolotId { get;  set;}
        public int ZalogaId { get;  set;}
        public string DataOdlotu { get;  set;}
        public string  DataPrzylotu { get;  set;}
    }
}
