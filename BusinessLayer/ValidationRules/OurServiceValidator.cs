using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ValidationRules
{
     public class OurServiceValidator: AbstractValidator<OurService>
    {
        public OurServiceValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Boş Olamaz!");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Başlık En Az 5 Karakterden Oluşmalıdır!");
            RuleFor(x => x.Title).MaximumLength(200).WithMessage("Başlık En Fazla 200 Karakterden Oluşmalıdır!");
            RuleFor(x => x.Text).NotEmpty().WithMessage("İçerik Boş Olamaz!");
            RuleFor(x => x.Text).MinimumLength(10).WithMessage("İçerik En Az 10 Karakterden Oluşmalıdır!");
            RuleFor(x => x.Text).MaximumLength(2000).WithMessage("İçerik En Fazla 200 Karakterden Oluşmalıdır!");
        }
    }
}
