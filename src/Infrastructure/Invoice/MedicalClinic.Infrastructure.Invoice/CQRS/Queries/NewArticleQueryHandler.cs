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
    /// <summary>
    /// 
    /// </summary>
    class NewArticleQueryHandler
    {
        /// <summary>
        /// 
        /// </summary>
        public class AddNewArticleQueryHandler : IRequestHandler<RequestAddNewArticleQuery, ResponseAddNewArticleQuery>
        {
            private IInvoiceRepository _context;
            private IMapper _mapper;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="context"></param>
            /// <param name="mapper"></param>
            public AddNewArticleQueryHandler(IInvoiceRepository context, IMapper mapper)
            {
                this._context = context;
                this._mapper = mapper;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="request"></param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            async public Task<ResponseAddNewArticleQuery> Handle(RequestAddNewArticleQuery request, CancellationToken cancellationToken)
            {
                var result = await _context.GetMultipleeInvoice(request.ACCOUNT_DETAIL_ID);
                return _mapper.Map<ResponseAddNewArticleQuery>(result);
            }
        }

     }
}
