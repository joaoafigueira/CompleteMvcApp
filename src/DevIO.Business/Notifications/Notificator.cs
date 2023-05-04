using DevIO.Business.Interfaces;

namespace DevIO.Business.Notifications
{
    public class Notificator : INotification
    {
        private List<Notification> _notifications;

        public Notificator()
        {
            _notifications = new List<Notification>();
        }

        public void Handle(Notification notificacao)
        {
            _notifications.Add(notificacao);
        }

        public List<Notification> ObterNotificacoes()
        {
            return _notifications;
        }

        public bool TemNotificao()
        {
            return _notifications.Any();
        }
    }
}
