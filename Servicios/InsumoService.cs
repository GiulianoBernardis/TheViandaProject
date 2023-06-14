using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheViandaProject.DTOs;
using TheViandaProject.Modelos;

namespace TheViandaProject.Servicios
{
    public class InsumoService
    {
        public GestorRespuesta<Insumo> Registrar(Insumo insumo)
        {
            insumo.FechaRegistro = DateTime.Now;
            insumo.FechaModificacion = DateTime.Now;
            try
            {
                using (var context = new AppDbContext())
                {
                    context.Insumos.Add(insumo);
                    context.SaveChanges();
                }

                return new GestorRespuesta<Insumo>(insumo);
            }
            catch (Exception)
            {
                return new GestorRespuesta<Insumo>(true, "Hubo un error al registrar el insumo");
            }
        }

        public Insumo? ObtenerPorId(int id)
        {
            using (var context = new AppDbContext())
            {
                return context.Insumos
                    .Where(x => x.Id == id && x.Deshabilitado == false)
                    .FirstOrDefault();
            }
        }

        public List<Insumo> ObtenerTodos()
        {
            using (var context = new AppDbContext())
            {
                return context.Insumos
                    .OrderBy(x => x.Deshabilitado)
                    .ToList();
            }
        }

        public GestorRespuesta<Insumo> Modificar (Insumo insumo)
        {
            insumo.FechaModificacion = DateTime.Now;
            try
            {
                using (var context = new AppDbContext())
                {
                    context.Insumos.Update(insumo);
                    context.SaveChanges();
                }

                return new GestorRespuesta<Insumo>(insumo);
            }
            catch (Exception)
            {
                return new GestorRespuesta<Insumo>(true, "Hubo un error al modificar el insumo");
            }
        }

        public bool CambiarEstado (int id, bool estado)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var insumo = context.Insumos.Where(x => x.Id == id).First();

                    insumo.Deshabilitado = estado;

                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
