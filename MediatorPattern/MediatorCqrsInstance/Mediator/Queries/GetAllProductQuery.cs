using MediatR;

namespace MediatorExample.Mediator.Queries
{
    public class GetAllProductQuery : IRequest<List<GetProductViewModel>>
    {
    }
}
