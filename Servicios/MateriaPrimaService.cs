using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheViandaProject.DTOs;
using TheViandaProject.Modelos;
using TheViandaProject_v2.Validaciones;

namespace TheViandaProject_v2.Servicios
{
    public class MateriaPrimaService
    {
        public GestorRespuesta<MateriaPrima> Registrar(MateriaPrima materiaPrima)
        {
            materiaPrima.FechaModificacion = DateTime.Now;
            materiaPrima.FechaRegistro = DateTime.Now;

            try
            {
                using (var context = new AppDbContext())
                {
                    context.MateriasPrimas.Add(materiaPrima);
                    context.SaveChanges();
                }

                return new GestorRespuesta<MateriaPrima>(materiaPrima);
            }
            catch (Exception)
            {
                return new GestorRespuesta<MateriaPrima>(true, "Hubo un problema al intentar registrar la materia prima");
            }
        }

        public MateriaPrima? ObtenerPorId(int id)
        {
            using (var context = new AppDbContext())
            {
                return context.MateriasPrimas
                    .Where(x => x.Id == id && x.Deshabilitado == false)
                    .FirstOrDefault();
            }
        }

        public List<MateriaPrima> ObtenerTodos()
        {
            using (var context = new AppDbContext())
            {
                return context.MateriasPrimas
                    .OrderBy(x => x.Deshabilitado)
                    .ToList();
            }
        }

        public GestorRespuesta<MateriaPrima> Modificar(MateriaPrima materia)
        {
            materia.FechaModificacion = DateTime.Now;

            try
            {
                using (var context = new AppDbContext())
                {
                    context.MateriasPrimas.Update(materia);
                    context.SaveChanges();
                }

                return new GestorRespuesta<MateriaPrima>(materia);
            }
            catch (Exception)
            {
                return new GestorRespuesta<MateriaPrima>(true, "Ocurrió un error al tratar de modificar la materia prima");
            }
        }

        public bool CambiarEstado(int id, bool estado)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var materia = context.MateriasPrimas.Where(x => x.Id == id).First();

                    materia.Deshabilitado = estado;

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
