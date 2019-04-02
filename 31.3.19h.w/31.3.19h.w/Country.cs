using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._3._19h.w
{
    class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SizeKm { get; set; }
        public int BirthYear { get; set; }
        public int CapitalCityId { get; set; }

        public override string ToString()
        {
            return $"Country {Id} {Name} {SizeKm} {BirthYear} {CapitalCityId}";
        }
    }
}
