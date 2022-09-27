using System;
using MediatR;
using MedicalClinic.Domain.Security.CQRS.Queries.Response;

namespace MedicalClinic.Domain.Security.CQRS.Queries.Request
{
    /// <summary>
    /// Request Login Query
    /// </summary>
    public class RequestLoginQuery : IRequest<ResponseLoginQuery>
    {
        /// <summary>
        /// User Name
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; set; }
    }
}
