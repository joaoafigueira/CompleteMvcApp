using DevIO.Business.Interfaces;

namespace DevIO.Business.Notifications
{
    public class Notification
    {
        public Notification(string mensagem)
        {
           Mensagem = mensagem;
        }

        public string Mensagem { get;}
    }
}
