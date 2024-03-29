
using MediatR;

namespace CSharp_MediatR.MediatR.Notifications
{
    public class ClienteInsertNotification : INotification
    {
        public int ClienteId { get; set; }
    }
}