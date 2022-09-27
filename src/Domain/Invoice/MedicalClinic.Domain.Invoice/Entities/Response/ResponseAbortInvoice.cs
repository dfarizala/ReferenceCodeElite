using System;
using System.Collections.Generic;
using MedicalClinic.Domain.Common.Wrappers;

namespace MedicalClinic.Domain.Invoice.Entities.Response
{
    /// <summary>
    /// Response for Abort Invoice
    /// </summary>
    public class ResponseAbortInvoice : ResponseApi
    {
        /// <summary>
        /// Account Header
        /// </summary>
        public AccountHeader Item { get; set; }
    }


}
