using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ValidationRules
{
    public class UserValidator : AbstractValidator<AppUser>
    {
        public UserValidator()
        {
            RuleFor(x => x.NameSurname).NotEmpty().WithMessage("Yazar adı soyadı kısmı boş geçilemez")
                .MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız")
                .MaximumLength(50).WithMessage("Lütfen en fazla 50 karakterlik veri girişi yapınız");

            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı kısmı boş geçilemez")
                .MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız")
                .MaximumLength(50).WithMessage("Lütfen en fazla 50 karakterlik veri girişi yapınız");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail adresi boş geçilemez")
                .EmailAddress().WithMessage("Mail adresinin mail formatında yazılması gerek");

            RuleFor(x => x.PasswordHash).NotEmpty().WithMessage("Şifre boş geçilemez")
                .Matches(@"[A-Z]+").WithMessage("Şifrede en az bir büyük harf olmalıdır.")
                .Matches(@"[a-z]+").WithMessage("Şifrede en az bir küçük harf olmalıdır.")
                .Matches(@"[0-9]+").WithMessage("Şifrede en az bir rakam olmalıdır");
        }
    }
}
