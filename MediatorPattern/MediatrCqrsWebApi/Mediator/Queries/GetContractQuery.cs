using MediatR;

namespace MediatrCqrsWebApi.Mediator.Queries
{
    public class GetContractQuery : IRequest<ContractResult>
    {
        public GetContractQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
