using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheViandaProject.Modelos;
using TheViandaProject.Validaciones;

namespace TheViandaProject_v2.Validaciones
{
    public class MateriaPrimaValidator : AbstractValidator<MateriaPrima>
    {
        public MateriaPrimaValidator()
        {
            RuleFor(x => x.Nombre).NotEmpty().WithMessage("La materia prima debe contar con un nombre identificativo");
            RuleFor(x => x.Costo).NotEmpty().WithMessage("La materia prima debe contar con un costo").GreaterThan(0).WithMessage("El costo debe ser mayor que 0");
            RuleFor(x => x.Cantidad).NotEmpty().WithMessage("La materia prima debe contar con una cantidad").GreaterThanOrEqualTo(0).WithMessage("La cantidad de materia prima no puede ser negativa");
            RuleFor(x => x.UnidadDeMedida).NotEmpty().WithMessage("La materia prima debe contar con una unidad de medida con la que procesarse");
        }
    }
}
