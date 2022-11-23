﻿using System.Collections.Generic;
using System.Linq;
using VentaDeMiel2022.Entidades.Dtos.Cliente;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Entidades.Enum;

namespace VentaDeMiel2022.Datos.Repositorio.Facade
{
    public interface IRepositorioCliente
    {
        void Guardar(Entidades.Entidades.Cliente cliente);

        List<Entidades.Entidades.Cliente> GetLista(TipoDeDocumento td, Localidad L, Provincia pr, Pais p/*, Orden orden*/);
        List<Entidades.Dtos.Cliente.ClienteListDto> GetLista2();
        void Borrar(int clienteId);

        Entidades.Entidades.Cliente GetClientePorId(int id);

        bool Existe(Entidades.Entidades.Cliente cliente);
        bool EstaRelacionado(Entidades.Entidades.Cliente cliente);
    }
}
