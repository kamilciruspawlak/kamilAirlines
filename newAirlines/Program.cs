using newAirlines.PersistanceContextEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newAirlines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new AirlineContext() )
            {
                
            foreach (var samolot in dbContext.TypSamolotu)
            {
                Console.WriteLine($"done {samolot.IloscMiejsc}");
            }
            Console.ReadLine();
            }
        }
    }
}
