using System;
using MediatR;
using MedicalClinic.Domain.Website.DTO.Response.Security;

namespace MedicalClinic.Domain.Website.DTO.Request.Security
{
    public class RequestRestorePasswordDto : IRequest<ResponseRestorePasswordDto>
    {
        /// <summary>
        /// User's mail
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Token with user's information
        /// </summary>
        public string token { get; set; }

        /// <summary>
        /// Password to establish on the User
        /// </summary>
        public string NewPassword { get; set; }
    }
}
