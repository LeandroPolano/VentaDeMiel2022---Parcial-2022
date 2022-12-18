using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VentaDeMiel2022.Entidades.Dtos;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Web.Models.Localidad;
using VentaDeMiel2022.Web.Models.Pais;
using VentaDeMiel2022.Web.Models.Provincia;

namespace VentaDeMiel2022.Web.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            LoadPaisMapping();
            LoadProvinciaMapping();
            LoadLocalidadMapping();
        }

        private void LoadLocalidadMapping()
        {
            CreateMap<Localidad, LocalidadEditVm>().ReverseMap();
       
            CreateMap<LocalidadListDto, LocalidadListVm>();

           
        }

        private void LoadProvinciaMapping()
        {
            CreateMap<Provincia, ProvinciaEditVm>().ReverseMap();
            CreateMap<ProvinciaListDto, ProvinciaListVm>();
            CreateMap<ProvinciaListDto, Provincia>();


        }

        private void LoadPaisMapping()
        {
           
            CreateMap<Pais, PaisEditVm>().ReverseMap();
            CreateMap<Pais, PaisListVm>();

        }
    }
}