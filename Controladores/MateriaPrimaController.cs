using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheViandaProject.DTOs;
using TheViandaProject.Modelos;
using TheViandaProject.Servicios;
using TheViandaProject.Validaciones;
using TheViandaProject_v2.Servicios;
using TheViandaProject_v2.Validaciones;

namespace TheViandaProject_v2.Controladores
{
    public class MateriaPrimaController
    {
        private MateriaPrimaService materiaService;
        public MateriaPrimaController()
        {
            materiaService = new MateriaPrimaService();
        }

        public GestorRespuesta<MateriaPrima> Registrar(MateriaPrima materia)
        {
            var validacion = new MateriaPrimaValidator();

            var resultado = validacion.Validate(materia);

            if (resultado.IsValid)
            {
                var resultadoRegistro = materiaService.Registrar(materia);

                if (resultadoRegistro.HayError)
                {
                    return new GestorRespuesta<MateriaPrima>(true, resultadoRegistro.MensajeError);
                }
                else
                {
                    return new GestorRespuesta<MateriaPrima>(resultadoRegistro.Respuesta);
                }
            }
            else
            {
                return new GestorRespuesta<MateriaPrima>(true, resultado.ToString());
            }
        }

        public MateriaPrima? ObtenerPorId(int id)
        {
            return materiaService.ObtenerPorId(id);
        }

        public List<MateriaPrima> ObtenerTodos()
        {
            return materiaService.ObtenerTodos();
        }

        public GestorRespuesta<MateriaPrima> Modificar(MateriaPrima materia)
        {
            var validacion = new MateriaPrimaValidator();

            var resultado = validacion.Validate(materia);

            if (resultado.IsValid)
            {
                var resultadoRegistro = materiaService.Modificar(materia);

                if (resultadoRegistro.HayError)
                {
                    return new GestorRespuesta<MateriaPrima>(true, resultadoRegistro.MensajeError);
                }
                else
                {
                    return new GestorRespuesta<MateriaPrima>(resultadoRegistro.Respuesta);
                }
            }
            else
            {
                return new GestorRespuesta<MateriaPrima>(true, resultado.ToString());
            }
        }

        public bool CambiarEstado(int id, bool estado)
        {
            return materiaService.CambiarEstado(id, estado);
        }

    }

   
}
