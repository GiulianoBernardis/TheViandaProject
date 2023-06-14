using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheViandaProject.DTOs;
using TheViandaProject.Modelos;
using TheViandaProject.Servicios;
using TheViandaProject.Validaciones;

namespace TheViandaProject.Controladores
{
    public class InsumoController
    {
        private InsumoService insumoService;

        public InsumoController()
        {
            insumoService = new InsumoService();
        }

        public GestorRespuesta<Insumo> Registrar(Insumo insumo)
        {
            var validacion = new InsumoValidator();

            var resultado = validacion.Validate(insumo);

            if (resultado.IsValid)
            {
                var resultadoRegistro = insumoService.Registrar(insumo);

                if (resultadoRegistro.HayError)
                {
                    return new GestorRespuesta<Insumo>(true, resultadoRegistro.MensajeError);
                }
                else
                {
                    return new GestorRespuesta<Insumo>(resultadoRegistro.Respuesta);
                }
            }
            else
            {
                return new GestorRespuesta<Insumo>(true, resultado.ToString());
            }
        }
        public Insumo? ObtenerPorId(int id)
        {
            return insumoService.ObtenerPorId(id);
        }
        public List<Insumo> ObtenerTodos()
        {
            return insumoService.ObtenerTodos();
        }
        public GestorRespuesta<Insumo> Modificar(Insumo insumo)
        {
            var validacion = new InsumoValidator();

            var resultado = validacion.Validate(insumo);

            if (resultado.IsValid)
            {
                var resultadoRegistro = insumoService.Modificar(insumo);

                if (resultadoRegistro.HayError)
                {
                    return new GestorRespuesta<Insumo>(true, resultadoRegistro.MensajeError);
                }
                else
                {
                    return new GestorRespuesta<Insumo>(resultadoRegistro.Respuesta);
                }
            }
            else
            {
                return new GestorRespuesta<Insumo>(true, resultado.ToString());
            }
        }
        public bool CambiarEstado(int id, bool estado)
        {
            return insumoService.CambiarEstado(id, estado);
        }
    }
}
