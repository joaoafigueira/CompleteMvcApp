using DevIO.Business.Notifications;

namespace DevIO.Business.Interfaces
{
    public interface INotification
    {
        bool TemNotificao();

        List<Notification> ObterNotificacoes();

        void Handle(Notification notificacao);
    }
}
