using CSharp_MediatR.MediatR.Requests;
using MediatR;

namespace CSharp_MediatR.MediatR.RequestsHandlers
{
    public class ClienteInsertHandler : IRequestHandler<ClienteInsertRequest, ClienteInsertResponse>
    {
        public Task<ClienteInsertResponse> Handle(ClienteInsertRequest request, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Eu sou o ClienteInsertHandler e o mediator me enviou um ClienteInsertRequest de nome  {request.Nome} para que eu insira no banco de dados");
            int ramdomId= new Random().Next(1, 100);
            return Task.FromResult(new ClienteInsertResponse (ramdomId));
        }
    }
}