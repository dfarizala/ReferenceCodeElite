using System;
using MediatR;
using MedicalClinic.Domain.Website.DTO.Response.Security;

namespace MedicalClinic.Domain.Website.DTO.Request.Security
{
    /// <summary>
    /// Request to update user's password
    /// </summary>
    public class RequestUpdatePasswordDto : IRequest<ResponseUpdatePasswordDto>
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
