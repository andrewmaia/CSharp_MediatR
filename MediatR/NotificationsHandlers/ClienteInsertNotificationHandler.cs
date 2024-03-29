using CSharp_MediatR.MediatR.Notifications;
using MediatR;

namespace CSharp_MediatR.MediatR.NotificationsHandlers
{
    public class ClienteInsertNotificationHandler : INotificationHandler<ClienteInsertNotification>
    {
        public Task Handle(ClienteInsertNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"Eu sou o ClienteInsertNotificationHandler e recebi uma notificação de um novo cliente com o id {notification.ClienteId}!");
            }, cancellationToken);
        }
    }
}