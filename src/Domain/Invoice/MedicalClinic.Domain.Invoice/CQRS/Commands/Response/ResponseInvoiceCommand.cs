using System;
using System.Collections.Generic;
using MedicalClinic.Domain.Common.Wrappers;
using MedicalClinic.Domain.Invoice.Entities;

namespace MedicalClinic.Domain.Invoice.CQRS.Commands.Response
{
    /// <summary>
    /// Response for Single Invoice Command 
    /// </summary>
    public class ResponseSingleInvoiceCommand : ResponseApi
    {
        /// <summary>
        /// Success
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// Account
        /// </summary>
        public AccountHeader Account { get; set; }
    }
    /// <summary>
    /// Response for Multiple Invoice Command
    /// </summary>
    public class ResponseMultipleInvoiceCommand : ResponseApi
    {
        /// <summary>
        /// Success
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Account Header
        /// </summary>
        public List<AccountHeader> Items { get; set; }
    }
    /// <summary>
    /// Response for Create Account
    /// </summary>
    public class ResponseCreateAccountCommand : ResponseApi
    {
        /// <summary>
        /// Account Id
        /// </summary>
        public int ACCOUNT_ID { get; set; }
    }

}
