using MediatR;

namespace MediatorExample.Mediator.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductViewModel>
    {
        public Task<GetProductViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var vm = new GetProductViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Book"
            };
            return Task.FromResult(vm);
            //Get product from repo
        }
    }
}