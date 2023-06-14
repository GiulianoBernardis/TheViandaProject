using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheViandaProject.Modelos
{
    public class DetalleReceta : EntidadDb
    {
        public MateriaPrima MateriaPrima { get; set; } = null!;
        public int Cantidad { get; set; }
    }
}
