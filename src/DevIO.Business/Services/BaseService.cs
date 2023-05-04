using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using DevIO.Business.Notifications;
using FluentValidation;
using FluentValidation.Results;

namespace DevIO.Business.Services
{
    public abstract class BaseService
    {
        private readonly INotification _notification;

        public BaseService(INotification notification)
        {
            _notification = notification;
        }

        protected void Notificar(ValidationResult validationResult)
        {
            foreach(var error in validationResult.Errors)
            {
                Notificar(error.ErrorMessage);
            }
        }


        protected void Notificar(string mensagem)
        {
            _notification.Handle(new Notification(mensagem));
        }

        protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade) where TV : AbstractValidator<TE> where TE: Entity
        {
            var validator = validacao.Validate(entidade);

            if (validator.IsValid) return true;

            Notificar(validator);
            return false;
        }
    }
}
