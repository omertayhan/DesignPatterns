using MediatR;

namespace MediatorExample.Mediator.Commands
{
    public class CreateProductCommand : IRequest<Guid>
    {
        public string? Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public class CreateProductCommmandHnadler : IRequestHandler<CreateProductCommand, Guid>
        {
            public Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
                return Task.FromResult(Guid.NewGuid());

                //repo ile veri dbye gönderilir
            }
        }
    }
}
