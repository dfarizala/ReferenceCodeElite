using System;
using MediatR;
using MedicalClinic.Domain.Invoice.Entities.Response;
using MedicalClinic.Domain.Common.Wrappers;

namespace MedicalClinic.Domain.Invoice.Entities.Request
{
    /// <summary>
    /// Request for Abort Invoice
    /// </summary>
    public class RequestAbortInvoice
    {
        /// <summary>
        /// Account Number
        /// </summary>
        public int ACCOUNT_ID { get; set; }
    }

}
