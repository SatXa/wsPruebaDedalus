using System.ComponentModel.DataAnnotations;

namespace wsPruebaDedalus.DTOs
{
    public class CountryDatumDTO
    {
        [StringLength(10)]
        public string countryIsoCode { get; set; }

        [StringLength(50)]
        public string countryName { get; set; }

        [StringLength(50)]
        public string countryCapital { get; set; }
    }
}
