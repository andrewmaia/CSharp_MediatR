using MediatR;

namespace CSharp_MediatR.MediatR.Requests
{
    public record ClienteInsertResponse(int ClienteId);
    public class ClienteInsertRequest  : IRequest<ClienteInsertResponse>
    {
        public string Nome { get; set; }
    }
}