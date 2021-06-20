using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wsPruebaDedalus.Models;

namespace wsPruebaDedalus.DTOs
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<CountryDatum, CountryDatumDTO>()
                .ReverseMap();
        }

    }
}
