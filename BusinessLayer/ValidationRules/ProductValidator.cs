using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ValidationRules
{
    public  class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Ürün Başlığı Boş Olamaz!");
            RuleFor(x => x.Title).MinimumLength(2).WithMessage("Ürün Başlığı En Az 2 Karakter Olmalıdır!");
            RuleFor(x => x.Title).MaximumLength(200).WithMessage("Ürün Başlığı En Fazla 50 Karakter Olmalıdır!");
            RuleFor(x => x.Brand).NotEmpty().WithMessage("Marka Boş Olamaz!");
            RuleFor(x => x.SubBrand).NotEmpty().WithMessage("Model Boş Olamaz!");
            RuleFor(x => x.Text).NotEmpty().WithMessage("Açıklama Boş Olamaz!");
        }
    }
}

