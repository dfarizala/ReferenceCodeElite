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
    public class SingleInvoiceQueryHandler : IRequestHandler<RequestSingleInvoiceQuery, ResponseSingleInvoiceQuery>
    {
        private IInvoiceRepository _context;
        private IMapper _mapper;

        public SingleInvoiceQueryHandler(IInvoiceRepository context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        async public Task<ResponseSingleInvoiceQuery> Handle(RequestSingleInvoiceQuery request, CancellationToken cancellationToken)
        {
            var result = await _context.GetSingleInvoice(request.ACCOUNT_ID);

            //TODO: esto es una chambonada el objeto tiene que devolverse completo para el mapper, favor cambiar 
            return new(){ Item = _mapper.Map<AccountHeader>(result) };
        }
    }

    public class MultipleInvoiceQueryHandler : IRequestHandler<RequestMultipleInvoiceQuery, ResponseMultipleInvoiceQuery>
    {
        private IInvoiceRepository _context;
        private IMapper _mapper;

        public MultipleInvoiceQueryHandler(IInvoiceRepository context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        async public Task<ResponseMultipleInvoiceQuery> Handle(RequestMultipleInvoiceQuery request, CancellationToken cancellationToken)
        {
            var result = await _context.GetMultipleeInvoice(request.PATIENT_ID, request.PATIENT_DOC_TYPE, request.PATIENT_DOC);
            return _mapper.Map<ResponseMultipleInvoiceQuery>(result);

        }
    }

    public class CreateAccountQueryHandler : IRequestHandler<RequestCreateAccountQuery, ResponseCreateAccountQuery>
    {
        private IInvoiceRepository _context;
        private IMapper _mapper;

        public CreateAccountQueryHandler(IInvoiceRepository context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        async public Task<ResponseCreateAccountQuery> Handle(RequestCreateAccountQuery request, CancellationToken cancellationToken)
        {
            var result = await _context.GetCreateAccount(request.ACCOUNT_ID, request.ADMISSION_ID, request.MEDICAL_HISTORY_ID, request.INVOICE_PREFIX, request.INVOICE_NUMBER, request.INVOICE_TYPE, request.ACCOUNT_DATE, request.INVOICE_GENERATION_DATE, request.INVOICE_GENERATION_TIME, request.HEAD_QUARTER_ID, request.RESPONSIBLE_CODE, request.AGREEMENT_CODE, request.ABORTED, request.PRINTED, request.ACTIVE, request.LOCKED, request.DIVIDED_ACCOUNT, request.SOAT_INVOICE, request.NET_VALUE, request.COPAY_VALUE, request.DISCOUNT, request.TOTAL_VALUE, request.LETTER_VALUE, request.QR_CODE, request.QR_PATH, request.AUTHORIZATION_NUMBER, request.PDF_PATH, request.IS_COVID, request.VERIFIED, request.SEND_MAIL, request.ADVANCED, request.DEBIT_NOTE, request.CREDIT_NOTE);
            
            return _mapper.Map<ResponseCreateAccountQuery>(result);           

        }

        
        }

}
