using MediatR;

namespace MediatorExample.Mediator.Queries
{
    public class GetProductByIdQuery : IRequest<GetProductViewModel>
    {
        public Guid Id { get; set; }
    }
}