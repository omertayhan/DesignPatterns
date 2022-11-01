using MediatR;

namespace MediatrWebApi.Handler
{
    public class MultiplyRequestHandler : IRequestHandler<MultiplyRequest, int>
    {
        public Task<int> Handle(MultiplyRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(request.Val1 * request.Val2);
        }
    }
}
