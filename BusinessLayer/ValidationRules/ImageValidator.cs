using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AdressValidator : AbstractValidator<Adress>
    {
        public AdressValidator()
        {
            RuleFor(x => x.Description1).NotEmpty().WithMessage("Açıklama 1 Boş Geçilemez");
            RuleFor(x => x.Description2).NotEmpty().WithMessage("Açıklama 2 Boş Geçilemez");
            RuleFor(x => x.Description3).NotEmpty().WithMessage("Açıklama 3 Boş Geçilemez");
            RuleFor(x => x.Description4).NotEmpty().WithMessage("Açıklama 4 Boş Geçilemez");
            RuleFor(x => x.Mapİnfo).NotEmpty().WithMessage("Harita Bilgisi Boş Geçilemez");
            RuleFor(x => x.Description1).MaximumLength(20).WithMessage("Lütfen Açıklamayı Kısaltın");
            RuleFor(x => x.Description2).MaximumLength(20).WithMessage("Lütfen Açıklamayı Kısaltın");
            RuleFor(x => x.Description3).MaximumLength(20).WithMessage("Lütfen Açıklamayı Kısaltın");
            RuleFor(x => x.Description4).MaximumLength(20).WithMessage("Lütfen Açıklamayı Kısaltın");
        }
    }
}
