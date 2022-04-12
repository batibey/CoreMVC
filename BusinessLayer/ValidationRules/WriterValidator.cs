using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Ad Soyad Boş Geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail Boş Geçilemez");
            RuleFor(x=>x.WriterPassword).NotEmpty().WithMessage("Şifre Boş Geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("En az 2 karakter girişi yapın");
        }
    }
}
