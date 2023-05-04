using DevIO.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.App.Controllers
{
    public class BaseController : Controller
    {
        private readonly INotification _notification;

        protected BaseController(INotification notification)
        {
            _notification = notification;
        }
        protected bool OperacaoValida()
        {
           return !_notification.TemNotificao();
        }

    }
}
