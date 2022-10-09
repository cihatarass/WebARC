using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ValidationRules
{
    public class ReferenceValidator: AbstractValidator<Reference>
    {

        public ReferenceValidator()
        {
            RuleFor(x => x.Project).NotEmpty().WithMessage("Proje İsmi Boş Bırakılamaz!");
            RuleFor(x => x.Project).MinimumLength(5).WithMessage("Proje Minumum 5 Karakterden Oluşmalıdır!");
            RuleFor(x => x.CompanyName).NotEmpty().WithMessage("Şirket/Personel Boş Bırakılamaz!");
            RuleFor(x => x.CompanyName).MinimumLength(5).WithMessage("Şirket/Personel Minumum 5 Karakterden Oluşmalıdır!");
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("Yazar/Yetkili Adı Boş Bırakılamaz!");
            RuleFor(x => x.PersonName).MinimumLength(5).WithMessage("Yazar/Yetkili Minumum 5 Karakterden Oluşmalıdır!");
            RuleFor(x => x.Comment).NotEmpty().WithMessage("Yorum/Değerlendirme Boş Bırakılamaz!");
            RuleFor(x => x.Comment).MinimumLength(5).WithMessage("Yorum/Değerlendirme Minumum 5 Karakterden Oluşmalıdır!");
        }
        
        
    }
}
