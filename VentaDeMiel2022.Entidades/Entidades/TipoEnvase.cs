using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaDeMiel2022.Entidades.Entidades
{
    public class TipoEnvase: ICloneable
    {
        public int TipoEnvaseId { get; set; }

        public string Descripcion { get; set; }


        //public ICollection<Provincia> Provincias { get; set; } = new List<Provincia>();

        public object Clone()
        {
            return this.MemberwiseClone();

        }
    }
}
