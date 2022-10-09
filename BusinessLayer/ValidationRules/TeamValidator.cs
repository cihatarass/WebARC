using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("Personel İsim Bilgisi Boş Olamaz!");
            RuleFor(x => x.PersonName).MinimumLength(5).WithMessage("Personel İsim Bilgisi En Az 5 Karakterden Oluşmalıdır.");
            RuleFor(x => x.Mission).NotEmpty().WithMessage("Personel İsim Bilgisi Boş Olamaz!");
            RuleFor(x => x.ShortBio).NotEmpty().WithMessage("Personel İsim Bilgisi Boş Olamaz!");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Personele ait Fotoğraf Boş Olamaz!");
        }
    }
}
