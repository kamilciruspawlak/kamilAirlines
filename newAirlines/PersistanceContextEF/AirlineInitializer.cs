using newAirlines.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newAirlines.PersistanceContextEF
{
    class AirlineInitializer : DropCreateDatabaseAlways<AirlineContext>
    {
        protected override void Seed(AirlineContext context)
        {
            IList<TypSamolotu> defaultStudents = new List<TypSamolotu>();
            defaultStudents.Add(new TypSamolotu()
            {
                Nazwa = "samolocik",
                IloscMiejsc= "pierdylion",
            });

            foreach (TypSamolotu TypSamolotu in defaultStudents)
                context.TypSamolotu.Add(TypSamolotu);
            base.Seed(context);
        }
    }
}
