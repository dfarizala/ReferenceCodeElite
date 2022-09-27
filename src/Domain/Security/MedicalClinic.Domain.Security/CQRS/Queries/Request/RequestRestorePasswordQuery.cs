using System;
using MediatR;
using MedicalClinic.Domain.Security.CQRS.Queries.Response;

namespace MedicalClinic.Domain.Security.CQRS.Queries.Request
{
    /// <summary>
    /// Request of restore password
    /// </summary>
    public class RequestRestorePasswordQuery : IRequest<ResponseRestorePasswordQuery>
    {
        /// <summary>
        /// Email of user
        /// </summary>
        public string Email { get; set; }
    }
}
