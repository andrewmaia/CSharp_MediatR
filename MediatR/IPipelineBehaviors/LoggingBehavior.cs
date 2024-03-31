using MediatR;

namespace CSharp_MediatR.MediatR.IPipelineBehaviors
{
    public class LoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Olá sou o LoggingBehavior e recebi o tipo request  {typeof(TRequest).Name} antes que o handler trate-o. Posso fazer qualquer tratamento com ele");
            
            var response = await next();
            

            Console.WriteLine($"Olá sou o LoggingBehavior e recebi o tipo response {typeof(TResponse).Name} depois que o handler o retornou. Posso fazer qualquer tratamento com ele");            
            
            return response;
        }
    }
}