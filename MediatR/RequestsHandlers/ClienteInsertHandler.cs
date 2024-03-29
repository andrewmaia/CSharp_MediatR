using CSharp_MediatR.MediatR.Notifications;
using CSharp_MediatR.MediatR.Requests;
using MediatR;

namespace CSharp_MediatR.MediatR.RequestsHandlers
{
    public class ClienteInsertHandler : IRequestHandler<ClienteInsertRequest, ClienteInsertResponse>
    {
        private readonly IMediator _mediator;
        public ClienteInsertHandler(IMediator mediator){
            _mediator = mediator;
        }

        public Task<ClienteInsertResponse> Handle(ClienteInsertRequest request, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Eu sou o ClienteInsertHandler e o mediator me enviou um ClienteInsertRequest de nome  {request.Nome} para que eu insira no banco de dados");
            int ramdomId= new Random().Next(1, 100);
            _mediator.Publish(new ClienteInsertNotification {  ClienteId = ramdomId});
            return Task.FromResult(new ClienteInsertResponse (ramdomId));
        }
    }
}