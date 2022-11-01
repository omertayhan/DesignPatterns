using System.Diagnostics.Contracts;
using MediatR;
using MediatrCqrsWebApi.Mediator.Queries;

namespace MediatrCqrsWebApi.Handler
{
    public class GetContractHandler : IRequest<GetContractQuery, ContractResult>
    {
        private readonly ILogger<GetContractHandler> _logger;
        private readonly IRepository<Contract> _contractRepository;
    }
}
