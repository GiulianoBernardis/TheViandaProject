using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheViandaProject.Modelos
{
    public class Receta : EntidadDb
    {
        public string Nombre { get; set; } = null!;
        public List<DetalleReceta> Ingredientes { get; set; } = null!;
        public int CostoManoObra { get; set; }
    }
}
