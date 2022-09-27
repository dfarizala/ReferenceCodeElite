using System;
using MedicalClinic.Domain.Common.Wrappers;

namespace MedicalClinic.Domain.Security.CQRS.Queries.Response
{
    /// <summary>
    /// Response for request of restore password
    /// </summary>
    public class ResponseRestorePasswordQuery : ResponseApi
    {
        /// <summary>
        /// User's mail
        /// </summary>
        public string Email { get; set; }
    }
}
