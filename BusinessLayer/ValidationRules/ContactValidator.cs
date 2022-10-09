using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator: AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("İletişim Sayfası Başlık Bilgisi Boş Bırakılamaz!");
            RuleFor(x => x.Adress).NotEmpty().WithMessage("Adres Bilgisi Boş Bırakılamaz!");
            RuleFor(x => x.Gsm).NotEmpty().WithMessage("Birincil Telefon Numarası Boş Bırakılamaz!");
            RuleFor(x => x.Gsm).MaximumLength(11).WithMessage("Birincil Telefon En Fazla 11 Karakterden Oluşturabilir!");
            RuleFor(x => x.Gsm).MinimumLength(11).WithMessage("Birincil Telefon En Az 11 Karakterden Oluşturabilir!");
            RuleFor(x => x.Gsm1).MaximumLength(11).WithMessage("İkincil Telefon En Fazla 11 Karakterden Oluşturabilir!");
            RuleFor(x => x.Gsm1).MinimumLength(11).WithMessage("İkincil Telefon En Az 11 Karakterden Oluşturabilir!");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Birincil E-posta Adresi Boş Bırakılamaz!");
        }
    }
}
