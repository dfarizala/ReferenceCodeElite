using System;
using System.Collections.Generic;
using MedicalClinic.Domain.Common.Wrappers;

namespace MedicalClinic.Domain.Invoice.Entities.Response
{
    /// <summary>
    /// Response for Single Invoice
    /// </summary>
    public class ResponseSingleInvoice : ResponseApi
    {
        /// <summary>
        /// Account Header
        /// </summary>
        public AccountHeader Item { get; set; }
    }
    /// <summary>
    /// Response for Multiple Invoice
    /// </summary>
    public class ResponseMultipleInvoice : ResponseApi
    {
        /// <summary>
        /// Account Header
        /// </summary>
        public List<AccountHeader> Items { get; set; }
    }
    /// <summary>
    /// Response for CreateAccount
    /// </summary>
    public class ResponseCreateAccount : ResponseApi
    {
        /// <summary>
        /// Primary Key for Account - Account Number
        /// </summary>
        public int ACCOUNT_ID { get; set; }
    }

 }
