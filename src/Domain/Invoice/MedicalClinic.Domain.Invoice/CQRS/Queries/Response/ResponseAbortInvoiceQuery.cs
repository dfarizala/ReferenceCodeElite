using System;
using System.Collections.Generic;
using MedicalClinic.Domain.Common.Wrappers;
using MedicalClinic.Domain.Invoice.Entities;


namespace MedicalClinic.Domain.Invoice.CQRS.Queries.Response
{
    /// <summary>
    /// Response Abort Invoice Query
    /// </summary>
    public class ResponseAbortInvoiceQuery : ResponseApi
    {
        /// <summary>
        /// Invoice Header
        /// </summary>
        public AccountHeader AbortedItem { get; set; }
    }

}
