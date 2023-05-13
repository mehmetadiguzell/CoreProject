﻿using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.ProjectName).NotEmpty().WithMessage("Proje adı boş geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel alanı boş geçilemez");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Görsel2 alanı boş geçilemez");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat alanı boş geçilemez");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Değer alanı boş geçilemez");
            RuleFor(x => x.ProjectName).MinimumLength(5).WithMessage("Proje adı en az 5 karakterden oluşmak zorundadır");
            RuleFor(x => x.ProjectName).MaximumLength(100).WithMessage("Proje adı en fazla 100 karakterden oluşmak zorundadır");
        }
    }
}
