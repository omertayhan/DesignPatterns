using MediatorExample.Mediator.Queries;
using MediatR;

namespace MediatrCqrsInstance.Mediator.Queries
{
    public class GetAllProductHandler : IRequestHandler<GetAllProductQuery, List<GetProductViewModel>>
    {
        public Task<List<GetProductViewModel>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            var model = new GetProductViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Book"
            };
            var model2 = new GetProductViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Monitor"
            };
            return Task.FromResult(new List<GetProductViewModel>() { model, model2 });
        }
    }
}