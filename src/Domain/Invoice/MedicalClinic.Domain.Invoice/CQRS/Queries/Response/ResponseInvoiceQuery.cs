using System;
using System.Collections.Generic;
using MedicalClinic.Domain.Common.Wrappers;
using MedicalClinic.Domain.Invoice.Entities;


namespace MedicalClinic.Domain.Invoice.CQRS.Queries.Response
{
    /// <summary>
    /// Response Single Invoice Query
    /// </summary>
    public class ResponseSingleInvoiceQuery: ResponseApi
    {
        /// <summary>
        /// Invoice Header
        /// </summary>
        public AccountHeader Item { get; set; }
    }
    /// <summary>
    /// Response Login Query
    /// </summary>
    public class ResponseMultipleInvoiceQuery : ResponseApi
    {
        /// <summary>
        /// List of invoices
        /// </summary>
        public List<AccountHeader> Items { get; set; }
    }
    /// <summary>
    /// Response Create Account Query
    /// </summary>
    public class ResponseCreateAccountQuery : ResponseApi
    {
        /// <summary>
        /// Primary Key for Account - Account Number
        /// </summary>
        public int ACCOUNT_ID { get; set; }
    }

}
