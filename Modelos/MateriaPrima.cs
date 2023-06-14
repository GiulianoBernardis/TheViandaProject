using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheViandaProject.Modelos
{
    public class MateriaPrima : EntidadDb
    {
        public string Nombre { get; set; } = null!;
        public int Cantidad { get; set; }
        public int Costo { get; set; }
        public string UnidadDeMedida { get; set; } = null!;
    }
}
