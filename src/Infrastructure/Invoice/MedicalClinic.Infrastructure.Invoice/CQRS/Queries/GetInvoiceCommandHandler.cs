using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MedicalClinic.Domain.Common.Wrappers;
using MedicalClinic.Domain.Invoice.Entities;
using MedicalClinic.Domain.Invoice.Entities.Request;
using MedicalClinic.Domain.Invoice.Entities.Response;

namespace MedicalClinic.Infrastructure.Invoice.CQRS.Queries
{
    //public class GetInvoiceCommandHandler: IRequestHandler<RequestInvoice, Response<ResponseSingleInvoice>>
    //{
    //    private readonly IMediator _mediator;


    //    public GetInvoiceCommandHandler(IMediator mediator)
    //    {
    //        _mediator = mediator;
    //    }

    //    async public Task<Response<ResponseSingleInvoice>> Handle(RequestInvoice request, CancellationToken cancellationToken)
    //    {
    //        return new() { Data = new ResponseSingleInvoice() { Item = new() { Name = "pepito" } } };
    //    }
    //}
}
