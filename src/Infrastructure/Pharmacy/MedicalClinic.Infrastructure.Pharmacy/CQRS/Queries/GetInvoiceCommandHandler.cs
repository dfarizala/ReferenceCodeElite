using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MedicalClinic.Domain.Common.Wrappers;
using MedicalClinic.Domain.Pharmacy.Entities;
using MedicalClinic.Domain.Pharmacy.Entities.Request;
using MedicalClinic.Domain.Pharmacy.Entities.Response;
using MedicalClinic.Domain.Pharmacy.Interfaces.Persistence;

namespace MedicalClinic.Infrastructure.Pharmacy.CQRS.Queries
{
    public class GetPharmacyCommandHandler: IRequestHandler<RequestPharmacy, Response<ResposeSinglePharmacy>>
    {
        private readonly IMediator _mediator;
        private readonly IArticleContext _context;


        public GetPharmacyCommandHandler(IMediator mediator, IArticleContext context)
        {
            _mediator = mediator;
            _context = context;
        }

        async public Task<Response<ResposeSinglePharmacy>> Handle(RequestPharmacy request, CancellationToken cancellationToken)
        {
            //return _context.SelectAll().ToList();
            return new() { Data = new ResposeSinglePharmacy() { Item = new() { Name = "pepito" } } };
        }
    }
}
