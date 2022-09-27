using System;
using MediatR;
using MedicalClinic.Domain.Security.CQRS.Commands.Response;
namespace MedicalClinic.Domain.Security.CQRS.Commands.Request
{
    /// <summary>
    /// Request for update password of User
    /// </summary>
    public class RequestUpdatePasswordCommand : IRequest<ResponseUpdatePasswordCommand>
    {
        /// <summary>
        /// User's mail
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Token with user's information for the update
        /// </summary>
        public string token { get; set; }

        /// <summary>
        /// New user's password
        /// </summary>
        public string NewPassword { get; set; }

        
    }
}
