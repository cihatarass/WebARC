using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator: AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Boş Olamaz!");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Başlık En Az 5 Karakterden Oluşmalıdır!");
            RuleFor(x => x.Title).MaximumLength(200).WithMessage("Başlık En Fazla 200 Karakterden Oluşmalıdır!");
            RuleFor(x => x.Text).NotEmpty().WithMessage("İçerik Boş Olamaz!");
            RuleFor(x => x.Text).MinimumLength(20).WithMessage("İçerik En Az 20 Karakterden Oluşmalıdır!");
            RuleFor(x => x.Author).NotEmpty().WithMessage("Yazar Boş Bırakılamaz!");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Boş Bırakılamaz!");
            RuleFor(x => x.Seo_Description).NotEmpty().WithMessage("Seo Açıklamları Boş Bırakılamaz!");
            RuleFor(x => x.Seo_Keywords).NotEmpty().WithMessage("Seo Anahtar Kelimeleri Boş Bırakılamaz!");
    
        }
    }
}
