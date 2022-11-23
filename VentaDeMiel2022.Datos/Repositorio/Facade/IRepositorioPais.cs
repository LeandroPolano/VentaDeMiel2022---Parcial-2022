﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeMiel2022.Entidades.Entidades;

namespace VentaDeMiel2022.Datos.Repositorio.Facade
{
    public interface IRepositorioPais
    {

        void Guardar(Pais pais);

        List<Pais> GetLista();

        void Borrar(int paisId);

        Pais GetPaisPorId(int id);

        bool Existe(Pais pais);
        bool EstaRelacionado(Pais pais);
    }
}
