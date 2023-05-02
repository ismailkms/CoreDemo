using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Blog başlığını boş geçemezsiniz")
                                 .MaximumLength(150).WithMessage("Lütfen 150 karakterden daha az veri girişi yapınız")
                                 .MinimumLength(5).WithMessage("Lütfen 5 karakterden daha fazla veri girişi yapınız");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Blog içeriğini boş geçemezsiniz")
                                   .MinimumLength(135).WithMessage("Lütfen 135 karakterden daha fazla veri girişi yapınız"); ;
        }
    }
}
