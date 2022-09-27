using System;
using System.Collections.Generic;
using MediatR;
using MedicalClinic.Domain.Invoice.CQRS.Queries.Response;
using MedicalClinic.Domain.Invoice.Entities;

namespace MedicalClinic.Domain.Invoice.CQRS.Queries.Request
{
    /// <summary>
    /// Request Abort Invoice Query
    /// </summary>
    public class RequestAbortInvoiceQuery : IRequest<ResponseAbortInvoiceQuery>
    {
        /// <summary>
        /// Account Number
        /// </summary>
        public int ACCOUNT_ID { get; set; }
    }
}
