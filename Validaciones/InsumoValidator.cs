using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheViandaProject.Modelos;

namespace TheViandaProject.Validaciones
{
    public class InsumoValidator : AbstractValidator<Insumo>
    {
        public InsumoValidator()
        {
            RuleFor(x => x.Nombre).NotEmpty().WithMessage("El nombre es obligatorio");
            RuleFor(x => x.Costo).GreaterThan(0).WithMessage("El costo tiene que ser mayor que cero");
        }
    }
}
