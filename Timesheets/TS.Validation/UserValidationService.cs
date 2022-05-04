using FluentValidation;
using TS.Data.Model;

namespace TS.Validation
{
    public class UserValidationService : AbstractValidator<Users>
    {
        public UserValidationService()
        {
            RuleFor(x => x.login)
                .NotEmpty()
                .WithMessage("Логин не должен быть пустым")
                .WithErrorCode("BRL-100.1");
            RuleFor(x => x.passwd)
                .NotEmpty()
                .WithMessage("Пароль не должен быть пустым")
                .WithErrorCode("BRL-100.2");
            RuleFor(x => x.passwd)
                .MinimumLength(5)
                .WithMessage("Пароль не может быть меньше 5 символов")
                .WithErrorCode("BRL-100.3");
        }
    }

}