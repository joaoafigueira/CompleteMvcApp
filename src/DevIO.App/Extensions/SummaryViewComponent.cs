using DevIO.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.App.Extensions
{
    public class SummaryViewComponent : ViewComponent
    {
        private readonly INotification _notification;

        public SummaryViewComponent(INotification notification)
        {
            _notification = notification;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var notificacoes = await Task.FromResult(_notification.ObterNotificacoes());
            notificacoes.ForEach(c => ViewData.ModelState.AddModelError(string.Empty, c.Mensagem));

            return View();
        }

    }
}
