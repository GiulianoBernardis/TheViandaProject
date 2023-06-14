using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheViandaProject.Modelos
{
    public class Vianda : EntidadDb
    {
        public string Nombre { get; set; }
        public List<Receta> Recetas { get; set; }
        public string Descripcion { get; set; }
        public int TiempoPreparacion { get; set; }
    }
}
