using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Web.Models.Pais;

namespace VentaDeMiel2022.Web.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            LoadPaisMapping();
            
        }

        private void LoadPaisMapping()
        {
            CreateMap<Pais, PaisEditVm>().ReverseMap();

        }
    }
}