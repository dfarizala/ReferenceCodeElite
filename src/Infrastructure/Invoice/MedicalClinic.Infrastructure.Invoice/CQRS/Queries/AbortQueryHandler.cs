using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using MedicalClinic.Domain.Invoice.CQRS.Queries.Request;
using MedicalClinic.Domain.Invoice.CQRS.Queries.Response;
using MedicalClinic.Domain.Invoice.Entities;
using MedicalClinic.Domain.Invoice.Interfaces.Persistence;


namespace MedicalClinic.Infrastructure.Invoice.CQRS.Queries
{
    public class AbortInvoiceQueryHandler : IRequestHandler<RequestAbortInvoiceQuery, ResponseAbortInvoiceQuery>
    {
        private IInvoiceRepository _context;
        private IMapper _mapper;

        public AbortInvoiceQueryHandler(IInvoiceRepository context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        async public Task<ResponseAbortInvoiceQuery> Handle(RequestAbortInvoiceQuery request, CancellationToken cancellationToken)
        {
            var result = await _context.AbortInvoice(request.ACCOUNT_ID);

            return new() { AbortedItem = _mapper.Map<AccountHeader>(result) };

        }

    }

}
