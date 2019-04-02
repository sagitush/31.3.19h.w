using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._3._19h.w
{
    class CapitalCity
    {
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public int NumCitizens { get; set; }
        public int CountryId { get; set; }

        public override string ToString()
        {
            return $"CapitalCity {Id} {Name} {NumCitizens} {CountryId}";
        }
    }
}
