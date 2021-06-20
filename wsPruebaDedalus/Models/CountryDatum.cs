using System;
using System.Collections.Generic;

#nullable disable

namespace wsPruebaDedalus.Models
{
    public partial class CountryDatum
    {
        public int Id { get; set; }
        public string CountryIsoCode { get; set; }
        public string CountryName { get; set; }
        public string CountryCapital { get; set; }
    }
}
