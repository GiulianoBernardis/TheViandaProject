using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheViandaProject.Modelos
{
    public abstract class EntidadDb
    {
        public int Id { get; set; }
        public bool Deshabilitado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
